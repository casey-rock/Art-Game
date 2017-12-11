using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p1scoreControl : MonoBehaviour {

   public GameObject textGameObject;
   private int score;
   
   void Start () {
score = 4; 
UpdateScore ();	 }
   
   public void AddScore (
int newScoreValue) {
score += newScoreValue; UpdateScore ();	}

   void UpdateScore () {
		Text scoreTextB = textGameObject.GetComponent<Text> ();
		if (score == 0) {
			
			Text scoreTextB_P2 = GameObject.Find ("GameController").GetComponent<p2scoreControl> ().textGameObject.GetComponent<Text>();
			GameObject.Find ("GameOverController").GetComponent<GameOver> ().gameOver_P1 = true;
			scoreTextB.text = "Game Over, P1 Wins!" +
				" Press B Button or R Key to Restart";

			scoreTextB_P2.text = "Game Over, P1 Wins!" +
				" Press B Button or R Key to Restart";
		} else {
			scoreTextB.text = "Art Pieces to Collect:" + score;	
		}

	}	
}
