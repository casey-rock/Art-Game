using UnityEngine;

public class player2 : MonoBehaviour
{
	Rigidbody m_Rigidbody;
	float m_Speed;

	void Start ()
	{
		//Fetch the Rigidbody component you attach from your GameObject
		m_Rigidbody = GetComponent<Rigidbody> ();
		//Set the speed of the GameObject
		m_Speed = 50.0f;
	}

	void Update ()
	{
		if (Input.GetAxis("LeftJoystickY_P2") > 0 || Input.GetKey(KeyCode.W)) {
			//Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
			m_Rigidbody.velocity = transform.forward * m_Speed;
		}

		if (Input.GetAxis("LeftJoystickY_P2") < 0 || Input.GetKey(KeyCode.S)) {
			//Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
			m_Rigidbody.velocity = -transform.forward * m_Speed;
		}

		if (Input.GetAxis("LeftJoystickY_P2") == 0 && !(Input.GetKey(KeyCode.W)) && !(Input.GetKey(KeyCode.S))) {
			//Stop the Rigidbody
			m_Rigidbody.velocity = transform.forward * 0;
		}

		if (Input.GetAxis("RightJoystickX_P2") < 0 || Input.GetKey(KeyCode.D)) {
			//Rotate the sprite about the Y axis in the positive direction
			transform.Rotate (new Vector3 (0, 1, 0) * Time.deltaTime * m_Speed, Space.World);
		}

		if (Input.GetAxis("RightJoystickX_P2") > 0 || Input.GetKey(KeyCode.A)) {
			//Rotate the sprite about the Y axis in the negative direction
			transform.Rotate (new Vector3 (0, -1, 0) * Time.deltaTime * m_Speed, Space.World);
		}
	}
    
}