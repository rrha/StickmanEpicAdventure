using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundAlignement : MonoBehaviour {
	public GameObject groundSpot;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		this.transform.position = groundSpot.transform.position;

	}

}
