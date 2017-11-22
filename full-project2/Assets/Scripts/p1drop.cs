﻿// this script ccreate a 'drop area' for player to place a picked up object.
//it is applied to the place we want to drop. Create an empty object and apply this script to it.
//the empty object is the 'area' that player must breach. this empty object must be a box collider

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  

public class p1drop : MonoBehaviour {

	private p1scoreControl gameController1;

	public GameObject item; //object we want to drop


	public GameObject tempParent; //what drop item is attached to
	public Transform drop; //where the object will go when dropped.

	bool playerInTrigger; ///this is used to indicate player is in 'drop zone'


void Start () {
        GameObject gameControllerObject = GameObject.FindWithTag ("GameController1");
        if (gameControllerObject != null) {
            gameController1 = gameControllerObject.GetComponent <p1scoreControl>();	}
        if (gameController1 == null) {
            Debug.Log ("Cannot find 'GameController' script");	}	}



	//this detect if player 1 is in 'drop area' to drop object
	void OnTriggerEnter (Collider col)
	{
		if(col.gameObject.name == "Player1")
		{

			Debug.Log("hitDrops");

			playerInTrigger = true;
		}
	}

	void OnTriggerExit(Collider col)
	{
		playerInTrigger = false;
	}

//this says if player is in 'drop area' and they press the right key, they will pick up object
	void Update(){

		if(playerInTrigger && (Input.GetButton("Submit") || Input.GetKeyDown(KeyCode.RightShift)) && item.transform.IsChildOf(tempParent.transform)){
			item.GetComponent<Rigidbody>().useGravity = false;
			item.GetComponent<Rigidbody>().isKinematic = false;
			item.transform.SetParent(drop);
			item.transform.position = drop.transform.position;
			Destroy(item.GetComponent<Collider>());
			gameController1.AddScore (-1);
			}
				
	}
}