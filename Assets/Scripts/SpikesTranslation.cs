using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesTranslation : MonoBehaviour {
	public starmovemet myStartMovemntEnable,mySecondStartMovemntEnable;
	SpikesTranslation spikesMovement;
	// Use this for initialization
	void Start () {
		spikesMovement= this.GetComponent<SpikesTranslation> ();
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D  (Collision2D collisionData) {
		if (collisionData.gameObject.CompareTag("Player")){
			mySecondStartMovemntEnable.enabled = true;
			myStartMovemntEnable.enabled = true;
			spikesMovement.enabled = false;

		}
	}
}
