using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class HealthManager : MonoBehaviour {
	public float health = 3;
	public Platformer2DUserControl playerControl;
	public PlatformerCharacter2D character;
	public Animator[] heartAnimation;
	public GameObject showGameObject, hideGameObject;
	public void addDamage (float damage){
		health -= damage;
		if (health <= 0){
			health = 0;
		}
		if (health == 2){
			heartAnimation [0].enabled = true;
		}
		if (health == 1){
			heartAnimation [1].enabled = true;
		} 
		if (health == 0){
			heartAnimation [2].enabled = true;
			playerControl.enabled = false;
			character.enabled = false;
			showGameObject.SetActive (true);
			hideGameObject.SetActive (false);
			Invoke ("PauseGame",1f);
		}
	}
	void Update (){
		if (health <= 0){
			health = 0;
		}
	}
	void PauseGame (){
		Time.timeScale = 0;
	}
}
