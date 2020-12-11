using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAudioHandle : MonoBehaviour {
	AudioSource buttonAudio;
	// Use this for initialization
	void Start () {
		buttonAudio = this.GetComponent <AudioSource> ();
	}

	void OnCollisionEnter2D (Collision2D collisionData) {
		if (collisionData.gameObject.CompareTag("Player")){
			buttonAudio.Play ();
		}
	}
}
