using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordAudioHandle : MonoBehaviour {
	float nextDamage = 0f;
	public float NextDamageRate = 1f;
	public Transform playerTrans;
	AudioSource sound;
	public float height;
	public float backPos,frontPos;
	// Use this for initialization
	void Start () {
		sound = this.GetComponent <AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y >= height && Time.time > nextDamage && playerTrans.position.x > backPos && playerTrans.position.x < frontPos) {
			sound.Play ();
			nextDamage = Time.time + NextDamageRate;
		} else {
			sound.Stop ();
		}
	}
}
