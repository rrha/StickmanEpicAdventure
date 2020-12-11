using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueScript : MonoBehaviour {
    public GameObject[] buttons;

	public void Continue () {
        buttons[0].SetActive(false);
        buttons[1].SetActive(true);
        Time.timeScale = 1;
	}
}
