using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButtonScript : MonoBehaviour {
	public GameObject currentMenu;
	public GameObject upComingMenu;
	public void Back () {
		currentMenu.SetActive (false);
		upComingMenu.SetActive (true);
	}

}
