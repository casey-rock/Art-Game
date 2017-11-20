using UnityEngine;

public class player2 : MonoBehaviour
{
	//create bullet
	//public GameObject bulletPrefab;
	//public Transform bulletSpawn;
	private Vector3 movementVector;
	private CharacterController characterController;
	private float movementSpeed = 30;




	void Start(){
		characterController = GetComponent<CharacterController> ();
		Debug.Log (characterController);
	}

	void Update()
	{
		movementVector.x = Input.GetAxis ("LeftJoystickX_P2") * movementSpeed;
		movementVector.z = Input.GetAxis("LeftJoystickY_P2") * movementSpeed;

		//transform.Rotate (Vector3.right, (Input.GetAxis ("RightJoystickX_P2") * movementSpeed * Time.deltaTime));

		characterController.Move (movementVector * Time.deltaTime);


		/*Fire on click
		if(Input.GetMouseButtonDown(0)){
			Fire();
		}*/
	}

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