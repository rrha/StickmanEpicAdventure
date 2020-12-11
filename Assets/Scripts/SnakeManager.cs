using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeManager : MonoBehaviour {
	public Transform playerTrans;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerTrans.position.x >= 1431f && playerTrans.position.x < 1454f) {
			anim.enabled = true;
			transform.localScale = new Vector2(8,8);
		}else if (playerTrans.position.x > 1470f){
			transform.localScale = new Vector2(-8,8);
		}

	}
}
