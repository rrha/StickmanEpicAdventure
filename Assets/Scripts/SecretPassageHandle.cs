using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretPassageHandle : MonoBehaviour {
	public Transform PlayerTrans;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D  (Collider2D other) {
		if (other.gameObject.CompareTag("Player")){
			gameObject.SetActive (false);
			
		}
	}
}
