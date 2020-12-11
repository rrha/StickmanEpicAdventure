using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class OpenDoor : MonoBehaviour {
	public Animator doorAnimator;
	SpriteRenderer playerOrder;
	public GameObject showGameObject;
	public GameObject hideGameObject;
	public Rigidbody2D topSpike;
	[SerializeField]
	private Rigidbody2D secondTopSpike;
	[SerializeField]
	private Rigidbody2D thirdTopSpike;
	[SerializeField]
	private GameObject player;
	void Awake (){
		topSpike.Sleep();
		secondTopSpike.Sleep();
		thirdTopSpike.Sleep();
		playerOrder = this.GetComponent<SpriteRenderer> ();
	}
	void OnCollisionEnter2D (Collision2D collisionData){
		if (collisionData.gameObject.CompareTag ("OpenDoor")) {
			doorAnimator.enabled = true;
			Invoke ("PlayerEnter",1f);
			Invoke ("ShowCanvas",1.5f);
		}else if (collisionData.gameObject.CompareTag ("TopSpike")) {
			topSpike.WakeUp();
		}else if (collisionData.gameObject.CompareTag ("TopSpikeTwo")) {
			secondTopSpike.WakeUp();
		}else if (collisionData.gameObject.CompareTag ("TopSpikeThree")) {
			thirdTopSpike.WakeUp();
		}
	}
	void PlayerEnter(){
		playerOrder.sortingLayerName = "BackGround";
		player.SetActive (false);
		
	}
	void ShowCanvas (){
		showGameObject.SetActive (true);
		hideGameObject.SetActive (false);

	}


}
