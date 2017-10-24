using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thedreamteleport : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter(Collider other){
		Application.LoadLevel( 2);
	}


	// Update is called once per frame
	void Update () {

	}
}
