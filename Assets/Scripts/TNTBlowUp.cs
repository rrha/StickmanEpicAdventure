using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNTBlowUp : MonoBehaviour {
	public GameObject fire;
	AudioSource explosion;
	// Use this for initialization
	void Start () {
		explosion = this.GetComponent <AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void EnableObject (){
		gameObject.SetActive (false);
	}
	void OnCollisionEnter2D (Collision2D collisionData){
		if (collisionData.gameObject.CompareTag("Player")){
			Invoke ("EnableObject",0.5f);
			fire.SetActive (true);
			explosion.Play ();
		}

	}

}
