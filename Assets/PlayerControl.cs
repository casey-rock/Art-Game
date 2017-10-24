using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	
	public float speed = 0.2f ;
	public string axisName = "Horizontal";
	public float jump = 1;

	void FixedUpdate () {
		//movement code
		transform.position += transform.right *Input.GetAxis(axisName)* speed;

		//jump code
		if (Input.GetKey(KeyCode.UpArrow)){
			Vector3 position = this.transform.position;
			position.y += jump / 4;
			this.transform.position = position;
		}

		//flip character based on movement direction
		if (Input.GetAxis (axisName) < 0){
			Vector3 newScale = transform.localScale;
			newScale.x = 1.0f;
			transform.localScale = newScale;
		}
		else if (Input.GetAxis (axisName) > 0){
			Vector3 newScale =transform.localScale;
			newScale.x = -1.0f;
			transform.localScale = newScale;
		}
	}

	
//	public float speed = 0.2f ;
//	public string axisName = "Horizontal";
//	public float jump = 1;
//
//	public Animator anim;
//	
//	void Start () {
//		anim = gameObject.GetComponent<Animator> ();
//	}
//	
//	void Update () {
//		transform.position += transform.right *Input.GetAxis(axisName)* speed * Time.deltaTime;
//
//		if (Input.GetKey(KeyCode.UpArrow)){
//			Vector3 position = this.transform.position;
//			position.y += jump;
//			this.transform.position = position;
//		}
//		
//		anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis(axisName)));
//		if (Input.GetAxis (axisName) < 0){
//			Vector3 newScale = transform.localScale;
//			newScale.y = 1.0f;
//			newScale.x = 1.0f;
//			transform.localScale = newScale;
//		}
//		else if (Input.GetAxis (axisName) > 0){
//			Vector3 newScale =transform.localScale;
//			newScale.x = -1.0f;
//			transform.localScale = newScale;
//		}
//	}
	

}
