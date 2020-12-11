using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class payramideMonsterFlipHandle : MonoBehaviour {
	public Transform playerTrans;
	SpriteRenderer flipSprite;
	// Use this for initialization
	void Start () {
		flipSprite = this.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerTrans.position.x > 1030){
			flipSprite.flipX = true;
		}else if (playerTrans.position.x > 1007 && playerTrans.position.x < 1030){
			flipSprite.flipX = false;

		}
	}
}
