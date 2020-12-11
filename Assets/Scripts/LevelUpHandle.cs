using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpHandle : MonoBehaviour {
	public GameObject[] snakes;
	public GameObject nextLevelKey;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (!snakes[0].activeInHierarchy&&!snakes[1].activeInHierarchy){
			nextLevelKey.SetActive (true);

		}

	}
}
