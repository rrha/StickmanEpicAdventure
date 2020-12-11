using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroScript : MonoBehaviour {
	public GameObject menuCanvas,gameManager;

	IEnumerator Start () {
		yield return new WaitForSeconds (8);
		Intro ();
	}
	
	// Update is called once per frame
	void Intro () {
		gameObject.SetActive (true);
		menuCanvas.SetActive (true);
		gameManager.SetActive (true);
	}
}
