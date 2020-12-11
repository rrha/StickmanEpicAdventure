using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablePlaying : MonoBehaviour {
	public MineVehicleMovement myMineScriptMovement;
	public TargetFollow myTargetFollow;
	public MonsterManager myMonsterScript;
	// Use this for initialization
	void Awake () {
		myMonsterScript.enabled = false;
		myTargetFollow.enabled = false;
		myMineScriptMovement.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		Invoke ("Enbale",4f);
	}
	void Enbale (){
		myMineScriptMovement.enabled = true;
		myTargetFollow.enabled = true;
		myMonsterScript.enabled = true;
	}
}
