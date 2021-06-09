using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using MessagePack;

public class RovSetup {
    public const int THRUSTER_HORIZONTAL_FORE_PORT = 0;
    public const int THRUSTER_HORIZONTAL_FORE_STARBOARD = 1;
    public const int THRUSTER_HORIZONTAL_AFT_PORT = 2;
    public const int THRUSTER_HORIZONTAL_AFT_STARBOARD = 3;
    public const int THRUSTER_VERTICAL_FORE_PORT = 4;
    public const int THRUSTER_VERTICAL_FORE_STARBOARD = 5;
    public const int THRUSTER_VERTICAL_AFT_PORT = 6;
    public const int THRUSTER_VERTICAL_AFT_STARBOARD = 7;

    public const int THRUSTER_COUNT = 8;

    public const float THRUSTER_POSITION_SCALE = 0.6f;

    public static Matrix4x4[] thrusterTransforms = new Matrix4x4[] {
        Matrix4x4.Translate(new Vector3(-1, 0, 1) * THRUSTER_POSITION_SCALE) * Matrix4x4.Rotate(Quaternion.Euler(90, 45, 0)),
        Matrix4x4.Translate(new Vector3(1, 0, 1) * THRUSTER_POSITION_SCALE) * Matrix4x4.Rotate(Quaternion.Euler(90, -45, 0)),
        Matrix4x4.Translate(new Vector3(-1, 0, -1) * THRUSTER_POSITION_SCALE) * Matrix4x4.Rotate(Quaternion.Euler(90, 135, 0)),
        Matrix4x4.Translate(new Vector3(1, 0, -1) * THRUSTER_POSITION_SCALE) * Matrix4x4.Rotate(Quaternion.Euler(90, -135, 0)),

        Matrix4x4.Translate(new Vector3(-1, 1, 1) * THRUSTER_POSITION_SCALE),
        Matrix4x4.Translate(new Vector3(1, 1, 1) * THRUSTER_POSITION_SCALE),
        Matrix4x4.Translate(new Vector3(-1, 1, -1) * THRUSTER_POSITION_SCALE),
        Matrix4x4.Translate(new Vector3(1, 1, -1) * THRUSTER_POSITION_SCALE)
    };
    
    private static bool serializerRegistered = false;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void Initialize() {
        if (!serializerRegistered) {
            MessagePack.Resolvers.StaticCompositeResolver.Instance.Register(
                 //MessagePack.Resolvers.GeneratedResolver.Instance,
                 MessagePack.Resolvers.StandardResolver.Instance
            );

            MessagePackSerializerOptions option = MessagePackSerializerOptions.Standard.WithResolver(MessagePack.Resolvers.StaticCompositeResolver.Instance);

            MessagePackSerializer.DefaultOptions = option;
            serializerRegistered = true;
        }
    }

#if UNITY_EDITOR
    [UnityEditor.InitializeOnLoadMethod]
    static void EditorInitialize() {
        Initialize();
    }
#endif
}
