using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
	public GameObject currentCanvas, upComingCanvas;
	public int healthCounter = 3;
	Animator anim;
	void Start (){
		anim = this.GetComponent <Animator> ();
	}
	void Update (){
		if (healthCounter == 3){
			currentCanvas.SetActive (true);
			upComingCanvas.SetActive (false);
		}else if (healthCounter == 2) {

			anim.SetBool ("GoodToGo", true);
			currentCanvas.SetActive (true);
			upComingCanvas.SetActive (false);
		}
	
}
}
