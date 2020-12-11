using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButtonScript : MonoBehaviour {
	public GameObject mainMenu;
	public GameObject settingsMenu;

	public void Settings (){
		mainMenu.SetActive (false);
		settingsMenu.SetActive (true);
	}
}
