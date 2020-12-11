using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
	
	public Transform starPoint;
	public float speed;
	bool canTransform = false; 

	void Update (){
		if (canTransform == true){
		transform.position = Vector2.MoveTowards(transform.position, starPoint.position, speed);
		}
	}
	void OnTriggerEnter2D(Collider2D other) {
		
		if (other.gameObject.CompareTag ("Player")) {
			canTransform = true;	
		}
		else if (other.gameObject.CompareTag ("Score")) {
			Destroy (gameObject);
		}
	}

}
