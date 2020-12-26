using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : MonoBehaviour {
	public float arrowHeight = 0.4f;

	public float crownRadius = 0.05f;
	public float crownHeight = 0.15f;

	void Start() {
		
	}

	void FixedUpdate() {
		Rigidbody rigidbody = gameObject.GetComponentInParent<Rigidbody>();
		
		rigidbody.AddForceAtPosition(transform.TransformPoint(3.0f * Time.deltaTime * Vector3.up), transform.position);
	}

	void OnDrawGizmos() {
		Vector3 arrowApex = transform.TransformPoint(Vector3.up * arrowHeight);

		Vector3 arrowCrown1 = transform.TransformPoint(Vector3.up * (arrowHeight - crownHeight) +
													  (Vector3.forward + Vector3.left) * crownRadius);
		Vector3 arrowCrown2 = transform.TransformPoint(Vector3.up * (arrowHeight - crownHeight) +
													  (Vector3.forward - Vector3.left) * crownRadius);
		Vector3 arrowCrown3 = transform.TransformPoint(Vector3.up * (arrowHeight - crownHeight) +
													  (-Vector3.forward + Vector3.left) * crownRadius);
		Vector3 arrowCrown4 = transform.TransformPoint(Vector3.up * (arrowHeight - crownHeight) +
													  (-Vector3.forward - Vector3.left) * crownRadius);

		Gizmos.color = Color.green;

		Gizmos.DrawLine(transform.position, arrowApex);
		Gizmos.DrawLine(arrowApex, arrowCrown1);
		Gizmos.DrawLine(arrowApex, arrowCrown2);
		Gizmos.DrawLine(arrowApex, arrowCrown3);
		Gizmos.DrawLine(arrowApex, arrowCrown4);
	}
}
