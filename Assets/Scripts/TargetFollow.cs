using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollow : MonoBehaviour {
	public Transform targetTransform;
	public bool followY = false;
	public bool followX = false;
    [SerializeField]
    float backToStop;
	[SerializeField]
	float frontToStop;
	[SerializeField]
	float DownToStop;
	// Update is called once per frame
	void LateUpdate () {
		if (targetTransform.position.x >= backToStop && targetTransform.position.x <= frontToStop && followX){
			Vector3 movement = new Vector3(targetTransform.position.x,transform.position.y,transform.position.z);
		transform.position = movement;
           
		}
		if (targetTransform.position.x >= backToStop && followY && targetTransform.position.y > DownToStop){
			
			Vector3 movement = new Vector3(transform.position.x,targetTransform.position.y,transform.position.z);
			transform.position = movement;

		}
	}

}
