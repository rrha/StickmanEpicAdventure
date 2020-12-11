using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakeBossManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D collisionData) {
		if (collisionData.gameObject.CompareTag("Cube")){
			this.gameObject.SetActive (false);
		}
	}
}
