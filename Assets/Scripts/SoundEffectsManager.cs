using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundEffectsManager : MonoBehaviour {
	[SerializeField] private AudioSource sFX1;
	[SerializeField] private AudioSource sFX2;
	[SerializeField] private AudioSource sFX3;
	[SerializeField] private AudioSource sFX4;
	[SerializeField] private AudioSource sFX5;
	[SerializeField] private AudioSource sFX6;
	[SerializeField] private AudioSource sFX7;
	[SerializeField] private AudioSource sFX8;
	[SerializeField] private AudioSource sFX9;
	[SerializeField] private AudioSource sFX10;


	public Toggle musicToggle;

	// Use this for initialization
	void Awake () {
		if (PlayerPrefs.GetFloat ("Volume") == 0) {
			sFX1.volume = 0;
			sFX2.volume = 0;
			sFX3.volume = 0;
			sFX4.volume = 0;
			sFX5.volume = 0;
			sFX6.volume = 0;
			sFX7.volume = 0;
			sFX8.volume = 0;
			sFX9.volume = 0;
			sFX10.volume = 0;


		} else if (PlayerPrefs.GetFloat ("Volume") == 1) {
			sFX1.volume = 1;
			sFX2.volume = 1;
			sFX3.volume = 1;
			sFX4.volume = 1;
			sFX5.volume = 1;
			sFX6.volume = 1;
			sFX7.volume = 1;
			sFX8.volume = 1;
			sFX9.volume = 1;
			sFX10.volume = 1;

		}
		
			
	}
	
	// Update is called once per frame
	public void DisbaleSFX () {
		if (!musicToggle.isOn){
			sFX1.volume = 0;
			sFX2.volume = 0;
			sFX3.volume = 0;
			sFX4.volume = 0;
			sFX5.volume = 0;
			sFX6.volume = 0;
			sFX7.volume = 0;
			sFX8.volume = 0;
			sFX9.volume = 0;
			sFX10.volume = 0;

		}
		else if (musicToggle.isOn)
		{
			sFX1.volume = 1;
			sFX2.volume = 1;
			sFX3.volume = 1;
			sFX4.volume = 1;
			sFX5.volume = 1;
			sFX6.volume = 1;
			sFX7.volume = 1;
			sFX8.volume = 1;
			sFX9.volume = 1;
			sFX10.volume = 1;

		}

	}
}
