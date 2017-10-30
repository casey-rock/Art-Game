using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class thedreamteleport : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter(Collider other){
		Scene sceneToLoad = SceneManager.GetSceneByName("the dream");
		SceneManager.LoadScene(sceneToLoad.name, LoadSceneMode.Additive);
		SceneManager.MoveGameObjectToScene(other.gameObject, sceneToLoad);

	}


	// Update is called once per frame
	void Update () {

	}
}
