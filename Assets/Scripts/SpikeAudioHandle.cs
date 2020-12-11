using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeAudioHandle : MonoBehaviour {
	AudioSource spikeFall;
	float nextDamage = 0f;
	float NextDamageRate = 1000000000000000000000000f;
	SpikeAudioHandle mySpikeHandle;
	// Use this for initialization
	void Start () {
		spikeFall = this.GetComponent <AudioSource> ();
		mySpikeHandle = this.GetComponent <SpikeAudioHandle> ();
	}
	
	void OnCollisionEnter2D (Collision2D collisionData) {
		if (collisionData.gameObject.CompareTag("Player")&&Time.time > nextDamage||collisionData.gameObject.CompareTag("TopSpike")&&Time.time > nextDamage||collisionData.gameObject.CompareTag("TopSpikeTwo")&&Time.time > nextDamage||collisionData.gameObject.CompareTag("TopSpikeThree")&&Time.time > nextDamage||collisionData.gameObject.CompareTag("Ground")&&Time.time > nextDamage){
			spikeFall.Play ();
			nextDamage = Time.time + NextDamageRate;
		}
	}
}
