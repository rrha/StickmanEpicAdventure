using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawAudio : MonoBehaviour {
	
	AudioSource sawAudio;
	public Transform playerTrans;
	public float backPos,frontPos;
	// Use this for initialization
	void Start () {
		sawAudio = this.GetComponent <AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerTrans.position.x > backPos && playerTrans.position.x < frontPos ){
			sawAudio.volume = 0.5f;
		}else if (playerTrans.position.x < backPos || playerTrans.position.x > frontPos ){
			sawAudio.volume = 0f;
		}
	}
}
