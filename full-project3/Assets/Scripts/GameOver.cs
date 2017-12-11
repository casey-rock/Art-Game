using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
	public bool gameOver_P1;
	public bool gameOver_P2;
	private bool restart;


	// Use this for initialization
	void Start () {
		gameOver_P1 = false;
		gameOver_P2 = false;
		restart = false;


	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver_P1) {
			restart = true;
		} else if (gameOver_P2) {
			restart = true;
		}

		if (restart) {
			if (Input.GetKeyDown (KeyCode.R) || Input.GetButton ("Game_Cancel")) {
				SceneManager.LoadScene ("3d area");
			}
		}
	}
}
