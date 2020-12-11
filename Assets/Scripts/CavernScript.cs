using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CavernScript : MonoBehaviour {
	public Transform player;
	Rigidbody2D rb;
	[SerializeField]
	private float gravityScaleAverage;
	public float transformToProcedue;
	// Use this for initialization
	void Awake () {
		rb = this.GetComponent <Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (player.position.x >= transformToProcedue){
			rb.gravityScale = gravityScaleAverage;
		}
	}
}
