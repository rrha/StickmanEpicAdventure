using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour {
	public Transform keyLock;
	bool move = false;
	Animator Anim;
	// Use this for initialization
	void Start () {
		Anim = this.GetComponent<Animator> ();
		
	}

	void OnCollisionEnter2D  (Collision2D collisionData) {
		if (collisionData.gameObject.CompareTag ("Player")) {
			Anim.enabled = false;
			move = true;
			Invoke ("DisableKey", 0.7f);
		}
	}
	void DisableKey(){
		gameObject.SetActive(false);
	}
	void Update (){
		if (move){
			transform.position = Vector2.MoveTowards(transform.position, keyLock.position, 2f);
		}
	}

}
