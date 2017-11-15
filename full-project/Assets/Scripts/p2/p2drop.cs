// this script ccreate a 'drop area' for player to place a picked up object.
//it is applied to the place we want to drop. Create an empty object and apply this script to it.
//the empty object is the 'area' that player must breach. this empty object must be a box collider

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  

public class p2drop : MonoBehaviour {

	private p2scoreControl gameController;

	public GameObject item; //object we want to drop
	public GameObject item1; //object we want to drop

	public GameObject item2; //object we want to drop

	public GameObject item3; //object we want to drop

	public GameObject item4; //object we want to drop

	public GameObject item5; //object we want to drop

	public GameObject item6; //object we want to drop

	public GameObject item7; //object we want to drop

	public GameObject item8; //object we want to drop
		public GameObject item9; //object we want to drop

	public GameObject item10; //object we want to drop

	public GameObject item11; //object we want to drop

	public GameObject item12; //object we want to drop



	public GameObject tempParent;
	public Transform drop; //where the object will go when dropped.

	bool playerInTrigger; ///this is used to indicate player is in 'drop zone'


void Start () {
        GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
        if (gameControllerObject != null) {
            gameController = gameControllerObject.GetComponent <p2scoreControl>();	}
        if (gameController == null) {
            Debug.Log ("Cannot find 'GameController' script");	}	}



	//this detect if player 1 is in 'drop area' to drop object
	void OnTriggerEnter (Collider col)
	{
		if(col.gameObject.name == "P2")
		{

			Debug.Log("hitDrops");

			playerInTrigger = true;
		}
	}

//this says if player is in 'drop area' and they press the right key, they will pick up object
	void Update(){

		if(playerInTrigger && Input.GetButtonDown("Submit") && item.transform.IsChildOf(tempParent.transform)){
			item.GetComponent<Rigidbody>().useGravity = false;
			item.GetComponent<Rigidbody>().isKinematic = false;
			item.transform.parent = null;
			item.transform.position = drop.transform.position;
			gameController.AddScore (1);
			}
		else if(playerInTrigger && Input.GetButtonDown("Submit") && item1.transform.IsChildOf(tempParent.transform)){
			item1.GetComponent<Rigidbody>().useGravity = false;
			item1.GetComponent<Rigidbody>().isKinematic = false;
			item1.transform.parent = null;
			item1.transform.position = drop.transform.position;
			gameController.AddScore (1);
			}
		else if(playerInTrigger && Input.GetButtonDown("Submit") && item2.transform.IsChildOf(tempParent.transform)){
			item2.GetComponent<Rigidbody>().useGravity = false;
			item2.GetComponent<Rigidbody>().isKinematic = false;
			item2.transform.parent = null;
			item2.transform.position = drop.transform.position;
			gameController.AddScore (1);
			}
		else if(playerInTrigger && Input.GetButtonDown("Submit") && item3.transform.IsChildOf(tempParent.transform)){
			item3.GetComponent<Rigidbody>().useGravity = false;
			item3.GetComponent<Rigidbody>().isKinematic = false;
			item3.transform.parent = null;
			item3.transform.position = drop.transform.position;
			gameController.AddScore (1);
			}
		else if(playerInTrigger && Input.GetButtonDown("Submit") && item4.transform.IsChildOf(tempParent.transform)){
			item4.GetComponent<Rigidbody>().useGravity = false;
			item4.GetComponent<Rigidbody>().isKinematic = false;
			item4.transform.parent = null;
			item4.transform.position = drop.transform.position;
			gameController.AddScore (1);
			}
		else if(playerInTrigger && Input.GetButtonDown("Submit") && item5.transform.IsChildOf(tempParent.transform)){
			item5.GetComponent<Rigidbody>().useGravity = false;
			item5.GetComponent<Rigidbody>().isKinematic = false;
			item5.transform.parent = null;
			item5.transform.position = drop.transform.position;
			gameController.AddScore (1);
			}
		else if(playerInTrigger && Input.GetButtonDown("Submit") && item6.transform.IsChildOf(tempParent.transform)){
			item6.GetComponent<Rigidbody>().useGravity = false;
			item6.GetComponent<Rigidbody>().isKinematic = false;
			item6.transform.parent = null;
			item6.transform.position = drop.transform.position;
			gameController.AddScore (1);
			}
		else if(playerInTrigger && Input.GetButtonDown("Submit") && item7.transform.IsChildOf(tempParent.transform)){
			item7.GetComponent<Rigidbody>().useGravity = false;
			item7.GetComponent<Rigidbody>().isKinematic = false;
			item7.transform.parent = null;
			item7.transform.position = drop.transform.position;
			gameController.AddScore (1);
			}
		else if(playerInTrigger && Input.GetButtonDown("Submit") && item8.transform.IsChildOf(tempParent.transform)){
			item8.GetComponent<Rigidbody>().useGravity = false;
			item8.GetComponent<Rigidbody>().isKinematic = false;
			item8.transform.parent = null;
			item8.transform.position = drop.transform.position;
			gameController.AddScore (1);
			}
		else if(playerInTrigger && Input.GetButtonDown("Submit") && item9.transform.IsChildOf(tempParent.transform)){
			item9.GetComponent<Rigidbody>().useGravity = false;
			item9.GetComponent<Rigidbody>().isKinematic = false;
			item9.transform.parent = null;
			item9.transform.position = drop.transform.position;
			gameController.AddScore (1);
			}
		else if(playerInTrigger && Input.GetButtonDown("Submit") && item10.transform.IsChildOf(tempParent.transform)){
			item10.GetComponent<Rigidbody>().useGravity = false;
			item10.GetComponent<Rigidbody>().isKinematic = false;
			item10.transform.parent = null;
			item10.transform.position = drop.transform.position;
			gameController.AddScore (1);
			}
		else if(playerInTrigger && Input.GetButtonDown("Submit") && item11.transform.IsChildOf(tempParent.transform)){
			item11.GetComponent<Rigidbody>().useGravity = false;
			item11.GetComponent<Rigidbody>().isKinematic = false;
			item11.transform.parent = null;
			item11.transform.position = drop.transform.position;
			gameController.AddScore (1);
			}
		else if(playerInTrigger && Input.GetButtonDown("Submit") && item12.transform.IsChildOf(tempParent.transform)){
			item12.GetComponent<Rigidbody>().useGravity = false;
			item12.GetComponent<Rigidbody>().isKinematic = false;
			item12.transform.parent = null;
			item12.transform.position = drop.transform.position;
			gameController.AddScore (1);
			}
	}
		}