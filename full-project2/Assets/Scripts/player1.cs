using UnityEngine;

public class player1 : MonoBehaviour
{
	//create bullet

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
		if (Input.GetAxis("LeftJoystickY") > 0 || Input.GetKey(KeyCode.UpArrow)) {
			//Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
			m_Rigidbody.velocity = transform.forward * m_Speed;
		}

		if (Input.GetAxis("LeftJoystickY") < 0 || Input.GetKey(KeyCode.DownArrow)) {
			//Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
			m_Rigidbody.velocity = -transform.forward * m_Speed;
		}

		if (Input.GetAxis("LeftJoystickY") == 0 && !(Input.GetKey(KeyCode.UpArrow)) && !(Input.GetKey(KeyCode.DownArrow))) {
			//Stop the Rigidbody
			m_Rigidbody.velocity = transform.forward * 0;
		}

		if (Input.GetAxis("RightJoystickX") < 0 || Input.GetKey(KeyCode.RightArrow)) {
			//Rotate the sprite about the Y axis in the positive direction
			transform.Rotate (new Vector3 (0, 1, 0) * Time.deltaTime * m_Speed, Space.World);
		}

		if (Input.GetAxis("RightJoystickX") > 0 || Input.GetKey(KeyCode.LeftArrow)) {
			//Rotate the sprite about the Y axis in the negative direction
			transform.Rotate (new Vector3 (0, -1, 0) * Time.deltaTime * m_Speed, Space.World);
		}
	}

	/*
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 40.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
	*/
		
}