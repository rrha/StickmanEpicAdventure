using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutButtonScript : MonoBehaviour {
	public GameObject settingsMenu;
	public GameObject aboutMenu;

	public void About () {
		settingsMenu.SetActive (false);
		aboutMenu.SetActive (true);
	}
}
