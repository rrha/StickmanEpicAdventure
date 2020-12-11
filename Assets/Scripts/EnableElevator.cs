using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableElevator : MonoBehaviour {
	public GameObject spikeMonsterLeft,spikeMonsterRight;
	public WanderScript elevatorScript;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!spikeMonsterLeft.activeInHierarchy && !spikeMonsterRight.activeInHierarchy){
			elevatorScript.enabled = true;
		}
	}
}
