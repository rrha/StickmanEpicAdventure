using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineButtonHandle : MonoBehaviour {
	public ElevatorManager myElevatorScript;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = this.GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D collisionData) {
		if (collisionData.gameObject.CompareTag("Cube")){
			myElevatorScript.move = true;
			anim.SetBool ("Onit",true);
		}
	}
}
