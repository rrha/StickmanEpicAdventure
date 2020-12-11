using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class DesertEnablePlaying : MonoBehaviour {
	public Platformer2DUserControl myUserControlScript;
	public GameObject cactusLeft;
	public GameObject cactusRight;
	// Update is called once per frame
	void Update () {
		Invoke ("DisableMovieEdges",4f);
	}
	void DisableMovieEdges (){
		myUserControlScript.enabled = true;
		cactusLeft.SetActive (true);
		cactusRight.SetActive (true);

	}


}
