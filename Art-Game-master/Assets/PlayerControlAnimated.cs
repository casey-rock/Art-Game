using UnityEngine;
using System.Collections;

public class PlayerControlAnimated : MonoBehaviour {
	
	public float speed = 0.2f ;
	public string axisName = "Horizontal";
	public float jump = 1;

	public Animator anim;
		
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
	}
		

	void Update () {
		//movement code
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)){
			transform.position += transform.right * Input.GetAxis(axisName)* speed;
			anim.Play("run");
		}

		//jump code
		if (Input.GetKey(KeyCode.UpArrow)){
			Vector3 position = this.transform.position;
			position.y += jump / 2;
			this.transform.position = position;
			anim.Play("jump");
		}

		anim.SetFloat("speed", Mathf.Abs(Input.GetAxis(axisName)));

		//flip character based on movement direction
		if (Input.GetAxis (axisName) < 0){
			Vector3 newScale = transform.localScale;
	//		newScale.y = 1.0f;
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
