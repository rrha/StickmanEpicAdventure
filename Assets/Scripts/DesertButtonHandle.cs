using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertButtonHandle : MonoBehaviour {
	public WanderScript topDownrock;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator> ();
	}
	
	void OnCollisionEnter2D (Collision2D collisionData){
		if (collisionData.gameObject.CompareTag("Player")){
			topDownrock.enabled = true;
			anim.enabled = true;
		}
	}
}
