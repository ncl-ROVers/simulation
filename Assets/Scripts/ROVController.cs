using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using UnityEngine;

using MessagePack;

using System.Threading;

public class ROVController : MonoBehaviour {
    private volatile bool isRunning = false;
    private Thread thread;

    public int port = 50000;

    private Socket masterSocket;
    private Socket streamSocket;
    private ConcurrentQueue<Tuple<int, float>> actionQueue;

    private float[] thrusterPower;
    private Rigidbody rigidbodyComponent;

    public float thrusterPowerSensitivity = 1.0f;

    void Start() {
        //Create server thread
        masterSocket = null;
        streamSocket = null;

        actionQueue = new ConcurrentQueue<Tuple<int, float>>();

        thread = new Thread(ServerCore);
        thread.IsBackground = true;
        thread.Start();

        //Get rigid body
        rigidbodyComponent = gameObject.GetComponent<Rigidbody>();

        //Initialize thruster power list
        thrusterPower = new float[RovSetup.THRUSTER_COUNT];

        for (int i = 0; i < RovSetup.THRUSTER_COUNT; ++i) {
            thrusterPower[i] = 0.0f;
        }
    }

    private float Normalize(float value, float currentMin, float currentMax, float intendedMin, float intendedMax) {
        return intendedMin + (value - currentMin) * (intendedMax - intendedMin) / (currentMax - currentMin);
    }

    void Update() {
        Tuple<int, float> action = new Tuple<int, float>(0, 0);

        while (actionQueue.TryDequeue(out action)) {
            thrusterPower[action.Item1] = Normalize(action.Item2, 1100, 1900, -1, 1);
        }
    }

    void FixedUpdate() {
        for (int i = 0; i < RovSetup.thrusterTransforms.Length; ++i) {
            Matrix4x4 thrusterWorldMatrix = transform.localToWorldMatrix * RovSetup.thrusterTransforms[i];

            Vector3 force = thrusterWorldMatrix.MultiplyVector(Vector3.up) * (thrusterPower[i] * thrusterPowerSensitivity);
            Vector3 position = thrusterWorldMatrix.MultiplyPoint(Vector3.zero);

            rigidbodyComponent.AddForceAtPosition(force, position, ForceMode.Force);
        }
    }

    void DrawThruster(Matrix4x4 transform, float arrowHeight, float crownRadius, float crownHeight) {
        Vector3 arrowApex = transform.MultiplyPoint3x4(Vector3.up * arrowHeight);

		Vector3 arrowCrown1 = transform.MultiplyPoint3x4(Vector3.up * (arrowHeight - crownHeight) +
												        (Vector3.forward + Vector3.left) * crownRadius);
		Vector3 arrowCrown2 = transform.MultiplyPoint3x4(Vector3.up * (arrowHeight - crownHeight) +
												        (Vector3.forward - Vector3.left) * crownRadius);
		Vector3 arrowCrown3 = transform.MultiplyPoint3x4(Vector3.up * (arrowHeight - crownHeight) +
													    (-Vector3.forward + Vector3.left) * crownRadius);
		Vector3 arrowCrown4 = transform.MultiplyPoint3x4(Vector3.up * (arrowHeight - crownHeight) +
													    (-Vector3.forward - Vector3.left) * crownRadius);

		Gizmos.DrawLine(transform.MultiplyPoint3x4(Vector4.zero), arrowApex);
		Gizmos.DrawLine(arrowApex, arrowCrown1);
		Gizmos.DrawLine(arrowApex, arrowCrown2);
		Gizmos.DrawLine(arrowApex, arrowCrown3);
		Gizmos.DrawLine(arrowApex, arrowCrown4);
    }

    void OnDrawGizmos() {
        if (thrusterPower != null) {
            for (int i = 0; i < RovSetup.thrusterTransforms.Length; ++i) {
                Matrix4x4 matrix = transform.localToWorldMatrix * RovSetup.thrusterTransforms[i];

                if (Math.Abs(thrusterPower[i]) > 0.0001) {
                    Gizmos.color = thrusterPower[i] < 0 ? Color.red : Color.green;
                } else {
                    Gizmos.color = Color.gray;
                }

                DrawThruster(matrix, 0.4f, 0.05f, 0.15f);
            }
        }

        Gizmos.color = Color.yellow;

        Matrix4x4 headMatrix = transform.localToWorldMatrix * (Matrix4x4.Translate(Vector3.forward * 0.6f) * Matrix4x4.Rotate(Quaternion.Euler(90, 0, 0)));
        DrawThruster(headMatrix, 0.55f, 0.06f, 0.16f);
    }

    void OnDisable() {
        isRunning = false;

        if (thread != null) {
            try {
                if (streamSocket != null) {
                    streamSocket.Shutdown(SocketShutdown.Both);
                }
                
                if (masterSocket != null) {
                    masterSocket.Shutdown(SocketShutdown.Both);
                }
            } catch (Exception) {
                //Do nothing
            }

            thread.Abort();
        }
    }

    byte[] ProcessROVMessage(byte[] message, int messageLength) {
        ReadOnlyMemory<byte> blob = new ReadOnlyMemory<byte>(message, 0, messageLength);
        var dynamicModel = MessagePackSerializer.Deserialize<dynamic>(blob, MessagePack.Resolvers.ContractlessStandardResolver.Options);
        
        actionQueue.Enqueue(new Tuple<int, float>(0, dynamicModel["T_HFP"]));
        actionQueue.Enqueue(new Tuple<int, float>(1, dynamicModel["T_HFS"]));
        actionQueue.Enqueue(new Tuple<int, float>(2, dynamicModel["T_HAP"]));
        actionQueue.Enqueue(new Tuple<int, float>(3, dynamicModel["T_HAS"]));
        actionQueue.Enqueue(new Tuple<int, float>(4, dynamicModel["T_VFP"]));
        actionQueue.Enqueue(new Tuple<int, float>(5, dynamicModel["T_VFS"]));
        actionQueue.Enqueue(new Tuple<int, float>(6, dynamicModel["T_VAP"]));
        actionQueue.Enqueue(new Tuple<int, float>(7, dynamicModel["T_VAS"]));

        dynamic empty = new System.Dynamic.ExpandoObject();
        byte[] responseData = MessagePackSerializer.Serialize<dynamic>(empty, MessagePack.Resolvers.ContractlessStandardResolver.Options);

        return responseData;
    }

    void ServerCore() {
        isRunning = true;

        //Create server socket
        Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        listener.Bind(new IPEndPoint(IPAddress.Any, port));
        listener.Listen(1);

        this.masterSocket = listener;

        Debug.Log("Starting ROV server ");

        //Start listening for connections
        while (isRunning) {
            try {
                Socket socket = listener.Accept();
                this.streamSocket = socket;

                Debug.Log("Accepted connection");

                //Read data from socket
                byte[] buffer = new byte[4096];

                while (isRunning) {
                    int read = socket.Receive(buffer);
                    
                    if (read > 0) {
                        byte[] response = ProcessROVMessage(buffer, read);

                        socket.Send(response);
                    }
                }

                socket.Close();
            } catch (ObjectDisposedException) {
                //Do nothing
            }

            Debug.Log("Closed connection");
        }

        Debug.Log("Terminating ROV server");

        listener.Close();
    }
}