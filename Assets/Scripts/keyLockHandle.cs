using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyLockHandle : MonoBehaviour {
	public GameObject lockObject;
	public GameObject stickGirlLocked,StickGirlFree;

	// Use this for initialization
	void Start () {
		
	}

	public void EnableKeyHandle (){
		stickGirlLocked.SetActive (false);
		StickGirlFree.SetActive (true);
		lockObject.SetActive (false);
	}
}
