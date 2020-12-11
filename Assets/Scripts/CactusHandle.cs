using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusHandle : MonoBehaviour {
	public Transform endPoint;
	public float timeToInvoke;
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Invoke ("MoveToEndPoint",timeToInvoke);
		if (transform.position.x == endPoint.position.x){
			Destroy (gameObject);
		}
	}
	void MoveToEndPoint (){
		transform.position = Vector2.MoveTowards(transform.position, endPoint.position, speed);

	}

}
