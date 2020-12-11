using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserManager : MonoBehaviour {
	public SpriteRenderer gameObjectLayer;
	public float enbaleTime;
	public PolygonCollider2D targetCollision;
	void Awake () {
		InvokeRepeating ("enbale",enbaleTime,1f);
	}
	void Update (){
		targetCollision.enabled = false;
		gameObjectLayer.enabled = false;
	}
	void enbale(){
		gameObjectLayer.enabled = true;
		targetCollision.enabled = true;

	}
}
