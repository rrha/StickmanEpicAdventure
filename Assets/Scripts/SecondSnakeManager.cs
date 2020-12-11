using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondSnakeManager : MonoBehaviour {
	public float backTrans, frontDist,SecondFrontDist;
	public Transform playerTrans;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (playerTrans.position.x >= backTrans && playerTrans.position.x < frontDist) {
			transform.localScale = new Vector2(7,7);
		}else if (playerTrans.position.x > SecondFrontDist){
			transform.localScale = new Vector2(-7,7);
		}
	}
}
