using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour {
	public Animator scaleGroundAnimator;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = this.gameObject.GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D collisionData) {
		if (collisionData.gameObject.CompareTag("Player")){
			scaleGroundAnimator.enabled = true;
			anim.SetBool ("Pushed",true);
		}
	}
}
