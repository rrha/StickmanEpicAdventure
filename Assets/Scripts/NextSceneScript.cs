using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSceneScript : MonoBehaviour {
	public GameObject currentScene; 
	public GameObject nextScene;

	public void Next () {
		currentScene.SetActive (false);
		nextScene.SetActive (true);

	}
}
