using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedoHandle : MonoBehaviour {
	public GameObject torpedoBlowUp;
	AudioSource blowUp;
	// Use this for initialization
	void Start () {
		blowUp = this.GetComponent <AudioSource> ();
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D collisionData) {
		if (collisionData.gameObject.CompareTag("Player")){
			torpedoBlowUp.SetActive (true);
			blowUp.Play ();
			Invoke ("DisabledgameObject",0.5f);
		}
		
	}
	void DisabledgameObject (){
		this.gameObject.SetActive (false);
	}
}
