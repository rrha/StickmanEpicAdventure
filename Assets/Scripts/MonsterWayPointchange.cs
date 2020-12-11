using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterWayPointchange : MonoBehaviour {
	public Transform playerTrans;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (playerTrans.position.x <= 1456f){
			transform.position = new Vector2 (1542f,transform.position.y);

		}else if (playerTrans.position.x >= 1540f){
			transform.position = new Vector2 (1457f,transform.position.y);
		}
	}
}
