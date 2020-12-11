using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLevelManager : MonoBehaviour {
	public GameObject nextLevel;
	public GameObject gamePlayButton;
	// Use this for initialization
	void Awake () {
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D collisionData) {
		if (collisionData.gameObject.CompareTag("Player")){
			nextLevel.SetActive (true);
			gamePlayButton.SetActive (false);
			Time.timeScale = 0;
		}
	}
}
