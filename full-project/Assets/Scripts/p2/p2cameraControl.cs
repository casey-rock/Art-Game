/* second draft
using UnityEngine;
using System.Collections;

public class p2cameraControl: MonoBehaviour {
	public GameObject player;

	private Vector3 offset;

	void start() {
		offset = transform.position - player.transform.position;
	}

	void LateUpdate()
	{
		transform.position = player.transform.position + offset;
	}
}
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2cameraControl : MonoBehaviour {

	public Transform player;
	private float movementSpeed = 50;

	// Update is called once per frame
	void Update () {
			
		transform.RotateAround(player.position, Vector3.up, (Input.GetAxis("RightJoystickX_P2") * movementSpeed * Time.deltaTime));
		//player.Rotate (Vector3.right, (Input.GetAxis ("RightJoystickX_P2") * movementSpeed * Time.deltaTime));

		//rotation.x -= Input.GetAxis ("RightJoystickX_P2") * rotationSpeed * Time.deltaTime;
		//rotation.y -= Input.GetAxis ("RightJoystickX_P2") * rotationSpeed * Time.deltaTime;

		//transform.eulerAngles = rotation;

	}
}
