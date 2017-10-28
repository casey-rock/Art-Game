using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lastsupperteleport : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider other){
		SceneManager.LoadScene("last supper");
	}


	// Update is called once per frame
	void Update () {
		
	}
}
