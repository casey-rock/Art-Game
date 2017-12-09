using UnityEngine;

public class player2 : MonoBehaviour
{
	Rigidbody m_Rigidbody;
	float m_Speed;

	public bool isPicked;
	private GameObject myPainting;

	void Start ()
	{
		//Fetch the Rigidbody component you attach from your GameObject
		m_Rigidbody = GetComponent<Rigidbody> ();
		//Set the speed of the GameObject
		m_Speed = 100.0f;

		isPicked = false;
		myPainting = null;
	}

	public void GetItem(GameObject item) 
	{
		// set myPainting to the item passed in from argument "item"
		myPainting = item;
	}

	public void dropItem()
	{
		myPainting.transform.position = myPainting.GetComponent<p2pickUp>().originalPosition;
		myPainting.transform.rotation = myPainting.GetComponent<p2pickUp> ().originalRotation;
		myPainting.GetComponent<p2pickUp> ().transform.parent = GameObject.Find ("p1pick").transform;
		GameObject.Find("Player2").GetComponent<player2>().isPicked = false;

		// drop the painting and reset the player's variable
		myPainting = null;
		// add code to reset painting to original spot
	}

	void Update ()
	{
		if (Input.GetKey (KeyCode.O)) {
			dropItem ();
		}
		if (Input.GetAxis("LeftJoystickX_P2") > 0 || Input.GetKey(KeyCode.T)) {
			m_Rigidbody.velocity = transform.right * m_Speed;
		}

		if (Input.GetAxis("LeftJoystickX_P2") < 0 || Input.GetKey(KeyCode.Y)) {
			m_Rigidbody.velocity = -transform.right * m_Speed;
		}

		if (Input.GetAxis("LeftJoystickY_P2") > 0 || Input.GetKey(KeyCode.W)) {
			//Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
			m_Rigidbody.velocity = transform.forward * m_Speed;
		}

		if (Input.GetAxis("LeftJoystickY_P2") < 0 || Input.GetKey(KeyCode.S)) {
			//Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
			m_Rigidbody.velocity = -transform.forward * m_Speed;
		}

		if (Input.GetAxis("LeftJoystickY_P2") == 0 && !(Input.GetKey(KeyCode.W)) && !(Input.GetKey(KeyCode.S)) && Input.GetAxis("LeftJoystickX_P2") == 0 && !Input.GetKey(KeyCode.T) && !Input.GetKey(KeyCode.Y)) {
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

	void OnTriggerEnter(Collider col){
		//if player2 bumps and p1 is holding a painting, send the painting back
		if (col.gameObject.name == "Player1" && isPicked) {
			//find which piece of the painting it is
			dropItem();
			//send it back
		}
	}
    
}