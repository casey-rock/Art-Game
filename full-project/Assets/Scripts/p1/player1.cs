using UnityEngine;

public class player1 : MonoBehaviour
{
	//create bullet
	//public GameObject bulletPrefab;
	//public Transform bulletSpawn;
	private Vector3 movementVector;
	private CharacterController characterController;
	private float movementSpeed = 30;
	private Rigidbody rigidBody;




	void Start(){
		characterController = GetComponent<CharacterController> ();
		rigidBody = GetComponent<Rigidbody> ();
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			//Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
			rigidBody.velocity = transform.forward * movementSpeed;
		}

		if (Input.GetKey(KeyCode.DownArrow))
		{
			//Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
			rigidBody.velocity = -transform.forward * movementSpeed;
		}

		if (Input.GetAxis("RightJoystickX") > 0)
		{
			//Rotate the sprite about the Y axis in the positive direction
			transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * movementSpeed, Space.World);
		}

		if (Input.GetAxis("RightJoystickX") < 0)
		{
			//Rotate the sprite about the Y axis in the negative direction
			transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * movementSpeed, Space.World);
		}

		/*
		movementVector.x = Input.GetAxis ("LeftJoystickX") * movementSpeed;
		movementVector.z = Input.GetAxis("LeftJoystickY") * movementSpeed;

		characterController.Move (movementVector * Time.deltaTime);

		var x = Input.GetAxis ("RightJoystickX") * Time.deltaTime * movementSpeed;

		transform.Rotate (0, x, 0);
		*/
		/*Fire on click
		if(Input.GetMouseButtonDown(0)){
			Fire();
		}*/
	}
	/*
	void FixedUpdate()
	{

		float horizontalAxis = Input.GetAxis ("RightJoystickX");

	}
*/
	/*Fire function
	void Fire(){
		//create bullet
		var bullet = (GameObject)Instantiate (
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);

		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

		// Destroy the bullet after 2 seconds
		Destroy(bullet, 2.0f); 
	}*/
}