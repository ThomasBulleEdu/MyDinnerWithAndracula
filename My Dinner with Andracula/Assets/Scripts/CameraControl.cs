using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

	public float mouseSensitivity = 1000f;
	public Transform playerBody;

	private float xRotation = 0f;
	private float yRotation = 0f;

	// Use this for initialization
	void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
	}

	// Update is called once per frame
	void Update()
	{

		float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
		float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;


		xRotation -= mouseY;
		xRotation = Mathf.Clamp(xRotation, -45f, 45f);

		yRotation -= mouseX;
		yRotation = Mathf.Clamp(yRotation, -45f, 45f);

		transform.localRotation = Quaternion.Euler(xRotation, -yRotation, 0f);
		playerBody.Rotate(Vector3.up * mouseX);

	}
}

