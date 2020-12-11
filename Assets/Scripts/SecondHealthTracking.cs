using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondHealthTracking : MonoBehaviour {

	public Health myHealthScript;
	public GameObject currentCanvas, upComingCanvas;
	public int healthCounter = 3;
	Animator anim;
	void Start (){
		anim = this.GetComponent <Animator> ();
	}

	
	// Update is called once per frame
	void Update () {
		if (myHealthScript.healthCounter == 0){
			anim.SetBool ("GoodToGo", true);
	
			Invoke ("GameOver",1);
		}
	}
	void GameOver (){
		currentCanvas.SetActive (false);
		upComingCanvas.SetActive (true);

	}
}
