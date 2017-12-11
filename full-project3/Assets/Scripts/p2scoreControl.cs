using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p2scoreControl : MonoBehaviour {

   public GameObject textGameObject;
   private int score;
   
   void Start () {
score = 5; 
UpdateScore ();	 }
   
   public void AddScore (
int newScoreValue) {
score += newScoreValue; UpdateScore ();	}

   void UpdateScore () {
		Text scoreTextB = textGameObject.GetComponent<Text> ();
		if (score <= 0) {

			Text scoreTextB_P1 = GameObject.Find ("GameController1").GetComponent<p1scoreControl> ().textGameObject.GetComponent<Text> ();
			GameObject.Find ("GameOverController").GetComponent<GameOver> ().gameOver_P2 = true;
			scoreTextB.text = "Game Over, P2 Wins!" +
			" Press B Button or R Key to Restart";

			scoreTextB_P1.text = "Game Over, P2 Wins!" +
			" Press B Button or R Key to Restart";
		} else {
			scoreTextB.text = "Art Pieces to Collect:" + score;	
		}
	}
}
