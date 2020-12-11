using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoublJumpAudio : MonoBehaviour {
	AudioSource doubleJump;
	// Use this for initialization
	void Start () {
		doubleJump = this.GetComponent <AudioSource> ();	
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D collisionData) {
		if (collisionData.gameObject.CompareTag("Player")){
			doubleJump.Play();
		}
	}
}
