using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour {
	AudioSource waterEffect;
	float nextDamage = 0f;
	float NextDamageRate = 1.5f;
	// Use this for initialization
	void Start () {
		waterEffect = this.GetComponent <AudioSource> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D  (Collider2D other) {
		if (other.gameObject.CompareTag("Player") && Time.time > nextDamage){
			nextDamage = Time.time + NextDamageRate;
			waterEffect.Play ();
		}
	}
}
