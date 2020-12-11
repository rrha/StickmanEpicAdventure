using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreSet : MonoBehaviour {
	int counter = 0;
	public Text scoreCounter;
	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.CompareTag ("Star")) {
			counter += 1;
			scoreCounter.text = "" + counter;
		}
	
	}
}
