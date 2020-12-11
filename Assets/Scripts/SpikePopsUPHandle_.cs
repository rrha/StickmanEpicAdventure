using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikePopsUPHandle_: MonoBehaviour {

	public WanderScript myWanderScript;
	public Animator anim;

	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D collisionData) {
		if (collisionData.gameObject.CompareTag("Player")){
			anim.enabled = true;
			Invoke ("DisableAnimator",1f);
		}
	}
	void DisableAnimator (){
		anim.enabled = false;
		myWanderScript.enabled = true;
		this.gameObject.SetActive (false);
	}
}
