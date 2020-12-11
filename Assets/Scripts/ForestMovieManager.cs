using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class ForestMovieManager : MonoBehaviour {
	public Platformer2DUserControl playerControl;
	public PlatformerCharacter2D character;
	public ForestBossManager monsterHandle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Invoke ("EnabledPlay",4f);	
	}
	void EnabledPlay(){
		playerControl.enabled = true;
		character.enabled = true;
		monsterHandle.enabled = true;
		Destroy (gameObject);
	}
}
