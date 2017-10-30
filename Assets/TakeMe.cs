using UnityEngine;
using System.Collections;

public class TakeMe : MonoBehaviour {

	private Transform taker;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.T)) {

			transform.parent = taker;

		} else if(Input.GetKey(KeyCode.G)) {

			transform.parent = null;

		}

	}

	void OnTriggerEnter (Collider col) {

		if(col.gameObject.CompareTag("Player")) {

			taker = col.transform;
			//this.gameObject.SetActive(false);

		}



	}    

	void OnTriggerExit (Collider col) {

		if(col.gameObject.CompareTag("Player")) {
			taker = null;
		}

	}
}