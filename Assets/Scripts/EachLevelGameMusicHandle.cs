using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EachLevelGameMusicHandle : MonoBehaviour {
	AudioSource gameManagerAudio;
	// Use this for initialization
	void Start () {
		gameManagerAudio = GameObject.Find("Game Manager").GetComponent<AudioSource>();
	}
	
	// Update is called once per frames
	void Update () {
		DontDestroyOnLoad (gameObject);
		if (gameManagerAudio.isPlaying ){
			gameObject.SetActive (false);
		}else if (!gameManagerAudio.isPlaying){
			gameObject.SetActive (true);
		} 
		
	}
}
