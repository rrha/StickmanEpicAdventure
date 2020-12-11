using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudioHandle : MonoBehaviour {
	AudioSource buttonAudio;
	float nextDamage = 0f;
	float NextDamageRate = 4f;
	// Use this for initialization
	void Start () {
		buttonAudio = this.GetComponent <AudioSource> ();
	}
	
	void OnCollisionEnter2D (Collision2D collisionData) {
		if (collisionData.gameObject.CompareTag("Player") && Time.time > nextDamage){
			buttonAudio.Play ();
			nextDamage = Time.time + NextDamageRate;
		}
	}
}
