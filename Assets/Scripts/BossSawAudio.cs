using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSawAudio : MonoBehaviour {
	AudioSource sawSfx;
	// Use this for initialization
	void Start () {
		sawSfx = this.GetComponent <AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y >= -24.06045f){
			sawSfx.volume = 0.5f;
		}else if (transform.position.y <= -24.06045f){
			sawSfx.volume = 0f;
		}
	}
}
