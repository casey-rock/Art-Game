using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastsupperteleport : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider other){
		Application.LoadLevel( 1);
	}


	// Update is called once per frame
	void Update () {
		
	}
}
