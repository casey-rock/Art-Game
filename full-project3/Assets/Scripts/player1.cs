using UnityEngine;

public class player1 : MonoBehaviour
{
	//create bullet
	public Animator anim;
	Rigidbody rigidbody;


	Rigidbody m_Rigidbody;
	float m_Speed;

	public bool isPicked;

	private GameObject myPainting;

	void Start ()
	{

		anim = gameObject.GetComponentInChildren<Animator>();
		rigidbody =gameObject.GetComponent<Rigidbody>();

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
		myPainting.transform.position = myPainting.GetComponent<p1pickup>().originalPosition;
		myPainting.transform.rotation = myPainting.GetComponent<p1pickup> ().originalRotation;
		myPainting.GetComponent<p1pickup> ().transform.parent = GameObject.Find ("p1pick").transform;
		GameObject.Find("Player1").GetComponent<player1>().isPicked = false;
		GameObject.Find ("Player1").GetComponent<player1> ().anim.SetBool ("carry", false);

		// drop the painting and reset the player's variable
		myPainting = null;
		// add code to reset painting to original spot
	}

	void Update ()
	{
		if (Input.GetKey (KeyCode.P)) {
			dropItem ();
		}
		if (Input.GetAxis("LeftJoystickX") > 0 || Input.GetKey(KeyCode.E)) {
			m_Rigidbody.velocity = transform.right * m_Speed;
			anim.SetBool ("run", true);
		}

		if (Input.GetAxis("LeftJoystickX") < 0 || Input.GetKey(KeyCode.Q)) {
			m_Rigidbody.velocity = -transform.right * m_Speed;
			anim.SetBool ("run", true);
		}

		if (Input.GetAxis("LeftJoystickY") > 0 || Input.GetKey(KeyCode.UpArrow)) {
			//Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
			m_Rigidbody.velocity = transform.forward * m_Speed;
			anim.SetBool ("run", true);
		}

		if (Input.GetAxis("LeftJoystickY") < 0 || Input.GetKey(KeyCode.DownArrow)) {
			//Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
			m_Rigidbody.velocity = -transform.forward * m_Speed;
			anim.SetBool ("run", true);
		}

		if (Input.GetAxis("LeftJoystickY") == 0 && !(Input.GetKey(KeyCode.UpArrow)) && !(Input.GetKey(KeyCode.DownArrow)) && Input.GetAxis("LeftJoystickX") == 0 && !Input.GetKey(KeyCode.E) && !Input.GetKey(KeyCode.Q)) {
			//Stop the Rigidbody
			m_Rigidbody.velocity = transform.forward * 0;
			anim.SetBool ("run", false);

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

	void OnTriggerEnter(Collider col){
		//if player2 bumps and p1 is holding a painting, send the painting back
		if (col.gameObject.name == "Player2" && isPicked) {
			dropItem ();
			anim.SetTrigger ("bump");
		}
	}

	/*
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 40.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
	*/
		
}