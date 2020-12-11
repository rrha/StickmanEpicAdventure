using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorScript : MonoBehaviour {
	public Transform palyerTrans;
	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D (Collision2D collisionData){
		if (collisionData.gameObject.CompareTag("Player")){
			palyerTrans.Translate (new Vector2(palyerTrans.position.x * speed,-63.72532f) * Time.deltaTime * Time.deltaTime);
		}
	}
}
