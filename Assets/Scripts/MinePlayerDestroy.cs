using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinePlayerDestroy : MonoBehaviour {
	public HealthManager healthDone;
	public GameObject deatheffect;
	float nextDamage = 0f;
	float NextDamageRate = 3f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (healthDone.health <=0){
			deatheffect.SetActive (false);
		}
	}
	void OnCollisionEnter2D (Collision2D collisionData){
		if (collisionData.gameObject.CompareTag("Danger") && Time.time > nextDamage){
			healthDone.addDamage (1);
			nextDamage = Time.time + NextDamageRate;

		}
	}
}
