using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
	public bool gameOver_P1;
	public bool gameOver_P2;
	private bool restart;

	public GameObject restartTextGO;
	public GameObject gameOverTextGO;


	// Use this for initialization
	void Start () {
		gameOver_P1 = false;
		gameOver_P2 = false;
		restart = false;


	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver_P1) {
			Text gameOverText = gameOverTextGO.GetComponent<Text> ();
			gameOverText.text = "Game Over! Player 1 Wins!";
			Text restartText = restartTextGO.GetComponent<Text> ();
			restartText.text = "Press 'R' on keyboard or 'A' on gamepad to restart";
			restart = true;
		} else if (gameOver_P2) {
			Text gameOverText = gameOverTextGO.GetComponent<Text> ();
			gameOverText.text = "Game Over! Player 2 Wins!";
			Text restartText = restartTextGO.GetComponent<Text> ();
			restartText.text = "Press 'R' on keyboard or 'A' on gamepad to restart";
			restart = true;
		}

		if (restart) {
			if (Input.GetKeyDown (KeyCode.R) || Input.GetButton ("Submit") || Input.GetButton ("Submit1")) {
				SceneManager.LoadScene ("3d area");
			}
		}
	}
}
