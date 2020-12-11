using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keysEnable : MonoBehaviour {
	public GameObject leftKey,rightKey;
	// Use this for initialization
	void EnableKeys () {
		leftKey.SetActive (true);
		rightKey.SetActive (true);
	}
	
	// Update is called once per frame
	void Awake () {
		Invoke ("EnableKeys",13f);
	}
}
