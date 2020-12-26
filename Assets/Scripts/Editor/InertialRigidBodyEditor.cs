using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(InertialRigidBody))]
public class InertialRigidBodyEditor : Editor {
	public override void OnInspectorGUI() {
		serializedObject.Update();

		InertialRigidBody rigidBody = (InertialRigidBody)target;

		//Render editor
		EditorGUILayout.PropertyField(serializedObject.FindProperty("mass"));
		EditorGUILayout.PropertyField(serializedObject.FindProperty("centerOfMass"));

		//Calculate buttons
		EditorGUILayout.BeginHorizontal();

		GUILayout.Label("Calculate:");
		if (GUILayout.Button("Center of Mass")) {
			rigidBody.centerOfMass = CalculateCenterOfMass(rigidBody);
		}

		if (GUILayout.Button("Inertia Tensor")) {

		}

		EditorGUILayout.EndHorizontal();

		serializedObject.ApplyModifiedProperties();
	}

	public void OnSceneGUI() {
		InertialRigidBody rigidBody = (InertialRigidBody)target;

		UnityEngine.Rendering.CompareFunction prevCompareFunc = Handles.zTest;
		Handles.zTest = UnityEngine.Rendering.CompareFunction.Disabled;

		Vector3 centerOfMass = rigidBody.transform.TransformPoint(rigidBody.centerOfMass);

		//Draw line from object position to center of mass
		Handles.color = Color.yellow;
		Handles.DrawAAPolyLine(3.0f, rigidBody.transform.position, centerOfMass);

		//Draw center of mass
		float comScale = 0.1f;
		
		Handles.color = Color.white;
		Handles.DrawLine(centerOfMass - Vector3.left * comScale, centerOfMass + Vector3.left * comScale);
		Handles.DrawLine(centerOfMass - Vector3.up * comScale, centerOfMass + Vector3.up * comScale);
		Handles.DrawLine(centerOfMass - Vector3.forward * comScale, centerOfMass + Vector3.forward * comScale);

		//Reset zTest
		Handles.zTest = prevCompareFunc;
	}

	private Vector3 CalculateCenterOfMass(InertialRigidBody rigidBody) {
		return new Vector3(1.0f, 0.0f, 0.0f);
	}
}
