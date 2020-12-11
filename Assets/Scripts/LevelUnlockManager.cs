using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUnlockManager : MonoBehaviour {
	public string nameOfLevel;
	public int numberOfLevel;

	void Start () {
		
	}
	
	void OnCollisionEnter2D(Collision2D CollisionData ){
		if (CollisionData.gameObject.CompareTag("Player")){
			PlayerPrefs.SetInt (nameOfLevel,numberOfLevel);
			PlayerPrefs.Save ();
		}
	}
	void OnTriggerEnter2D(Collider2D other ){
		if (other.gameObject.CompareTag("Player")){
			PlayerPrefs.SetInt (nameOfLevel,numberOfLevel);
			PlayerPrefs.Save ();
		}
	}
}
