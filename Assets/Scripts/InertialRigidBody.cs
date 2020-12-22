using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InertialRigidBody : MonoBehaviour {
	public float mass = 1.0f;

	public Vector3 centerOfMass;

	private void Start() {
		centerOfMass = new Vector3();
	}

	private void FixedUpdate() {
		
	}

	public void addForce(Vector3 position, Vector3 force, Space space) {
		
	}
}
