using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p2scoreControl : MonoBehaviour {

   public GameObject textGameObject;
   private int score;
   
   void Start () {
score = 4; 
UpdateScore ();	 }
   
   public void AddScore (
int newScoreValue) {
score += newScoreValue; UpdateScore ();	}

   void UpdateScore () {
	Text scoreTextB = textGameObject.GetComponent<Text>();
	scoreTextB.text = "Art Pieces to Collect:" + score;	
		if (score == 0) {
			GameObject.Find ("GameOverController").GetComponent<GameOver> ().gameOver_P2 = true;
		}
	}	
}
