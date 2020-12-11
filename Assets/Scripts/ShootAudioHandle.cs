using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAudioHandle : MonoBehaviour {
	float nextDamage = 0f;
	public float NextDamageRate = 1f;
	AudioSource sawAudio;
	public Transform playerTrans;
	public float backPos,frontPos;
	// Use this for initialization
	void Start () {
		sawAudio = this.GetComponent <AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		if (playerTrans.position.x > backPos && playerTrans.position.x < frontPos && Time.time > nextDamage){
			sawAudio.Play ();
			nextDamage = Time.time + NextDamageRate;
		}else if (playerTrans.position.x < backPos || playerTrans.position.x > frontPos ){
			sawAudio.Stop();

		}
	}
}
