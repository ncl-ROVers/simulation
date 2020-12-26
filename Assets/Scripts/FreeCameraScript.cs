using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCameraScript : MonoBehaviour {
	private GameControls gameControls;
	private bool isActive = true;

	public float movementSpeed = 9.0f;
	public float fastSpeed = 14.0f;
	public float lookSensitivity = 1.0f;

	private void Awake() {
		gameControls = new GameControls();

		gameControls.CameraMovement.Toggle.performed += _ => ToggleCamera();
	}

	private void OnEnable() {
		gameControls.Enable();
	}

	private void OnDisable() {
		gameControls.Disable();
	}

	void Start() {
		gameObject.SetActive(true);
	}

	private void ToggleCamera() {
		isActive = !isActive;
	}

	void Update() {
		if (!isActive) {
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;

			return;
		}

		Cursor.lockState = CursorLockMode.Locked;

		//Update movement
		float rightLeft = gameControls.CameraMovement.RightLeft.ReadValue<float>();
		float frontBack = gameControls.CameraMovement.FrontBack.ReadValue<float>();
		float upDown = gameControls.CameraMovement.UpDown.ReadValue<float>();

		float fastPercentage = gameControls.CameraMovement.FastFly.ReadValue<float>();

		float moveAmout = Time.deltaTime * Mathf.Lerp(movementSpeed, fastSpeed, fastPercentage);

		transform.Translate(new Vector3(rightLeft, 0.0f, frontBack) * moveAmout, Space.Self);
		transform.Translate(new Vector3(0.0f, upDown, 0.0f) * moveAmout, Space.World);

		//Update orientation
		float pitchAdjust = gameControls.CameraMovement.LookPitch.ReadValue<float>() * lookSensitivity;
		float yawAdjust =  gameControls.CameraMovement.LookYaw.ReadValue<float>() * lookSensitivity;

		transform.Rotate(0.0f, yawAdjust, 0.0f, Space.World);
		transform.Rotate(-pitchAdjust, 0.0f, 0.0f, Space.Self);
	}
}
