using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnlockLevel : MonoBehaviour {
	public string nameOfLevel;
	public int numberOfLevel;
	public Button activeButton;

	void Awake () {
		activeButton.enabled = false;

	}
	
	void Update () {
		if (PlayerPrefs.GetInt(nameOfLevel) == numberOfLevel){
			activeButton.enabled = true;
			PlayerPrefs.Save ();
		}
	}
}
