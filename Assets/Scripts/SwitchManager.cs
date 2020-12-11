using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchManager : MonoBehaviour {
	Animator anim;
	public Animator ropeScale;
	// Use this for initialization
	void Start () {
		anim = this.GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D (Collision2D collisionData){
		if (collisionData.gameObject.CompareTag("Player")){
			anim.SetBool ("On",true);
			ropeScale.enabled = true;
		}
	}
}
