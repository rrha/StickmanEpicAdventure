using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnterNextLevel : MonoBehaviour {
	public GameObject player;
	public GameObject showGameObject;
	public GameObject hideGameObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D collisionData) {
		if (collisionData.gameObject.CompareTag("Player")){
			player.SetActive (false);
			showGameObject.SetActive (true);
			hideGameObject.SetActive (false);

		}
	}
}
