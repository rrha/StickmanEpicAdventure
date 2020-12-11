using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineVehicleMovement : MonoBehaviour {
	public float speed;
	public Transform mineVehicleEndPoint;
	Rigidbody2D rb;
	public GameObject monster;
	public float jumpStrenght;
	bool canJump;
	bool enableFeature = true;
	AudioSource jumpSfx;
	public AudioSource speedUpSfx;
	MineVehicleMovement myMineMovement;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent <Rigidbody2D> ();
		myMineMovement = this.GetComponent <MineVehicleMovement> ();
		jumpSfx = this.GetComponent <AudioSource> ();
	}
	
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, mineVehicleEndPoint.position, speed * Time.deltaTime);
		if (Input.GetKeyDown("space") && canJump && enableFeature){
			Jump ();
			jumpSfx.Play ();
			canJump = false;
		}
		if (Input.GetKeyDown(KeyCode.S) && canJump && enableFeature){
			SpeedUp ();
			canJump = false;
			speedUpSfx.Play ();
		}
		if (transform.position.x >= mineVehicleEndPoint.position.x){
			enableFeature = false;
			monster.SetActive (false);
			myMineMovement.enabled = false;
		}
	}
	public void Jump (){
		if (canJump){
		rb.AddForce (Vector2.up * jumpStrenght);
		jumpSfx.Play ();
		canJump = false;
		}
	}
	public void SpeedUp (){
		rb.AddForce (Vector2.right * 2000);
		speedUpSfx.Play ();
	}
	void OnCollisionEnter2D (Collision2D collisionData){
		if (collisionData.gameObject.CompareTag("Ground") ||collisionData.gameObject.CompareTag("TopSpike") ||collisionData.gameObject.CompareTag("TopSpikeTwo") ||collisionData.gameObject.CompareTag("TopSpikeThree") ||collisionData.gameObject.CompareTag("OpenDoor") || collisionData.gameObject.CompareTag("TopSpikeFour") ){
			canJump = true; 
		}
		
	}
}
