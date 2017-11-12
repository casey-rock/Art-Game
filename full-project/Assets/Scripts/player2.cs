using UnityEngine;

public class player2 : MonoBehaviour
{
	//create bullet
	public GameObject bulletPrefab1;
	public Transform bulletSpawn1;

    void Update()
    {
        var x = Input.GetAxis("Horizontal1") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical1") * Time.deltaTime * 15.0f;

		transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

		//Fire on space
		if(Input.GetMouseButtonDown(1)){
			Fire();
		}
    }

	//Fire function
	void Fire(){
		//create bullet
		var bullet1 = (GameObject)Instantiate (
			bulletPrefab1,
			bulletSpawn1.position,
			bulletSpawn1.rotation);

		// Add velocity to the bullet
		bullet1.GetComponent<Rigidbody>().velocity = bullet1.transform.forward * 6;

		// Destroy the bullet after 2 seconds
		Destroy(bullet1, 2.0f); 
	}
}