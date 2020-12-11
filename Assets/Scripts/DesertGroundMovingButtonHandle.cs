using System.Collections.Generic;
using UnityEngine;

public class DesertGroundMovingButtonHandle : MonoBehaviour {
	public starmovemet topDownrock;
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
