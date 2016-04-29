using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	CharacterController controller;
	// Use this for initialization
	void Start () {
	
		controller = GetComponent<CharacterController> ();
	}

	void MoveForward(){
	
		//character facing towards
		Vector3 forward = transform.forward;


		//character running 20m per second
		controller.Move (forward * Time.deltaTime * 20);
	}
	public void MoveLeftRight(int dir){
		Vector3 right = transform.right;

		controller.Move (right * dir * Time.deltaTime*20);

	}

	void UpdateControlller(){

		if(Input.GetKey (KeyCode.A)){
			MoveLeftRight(-1);

		}
		if(Input.GetKey(KeyCode.D)){
			MoveLeftRight(1);

		}

	}
	// Update is called once per frame
	void Update () {
		MoveForward ();
			UpdateControlller ();
		
	
	}
}
