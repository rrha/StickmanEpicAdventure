using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawMovement : MonoBehaviour {
	[SerializeField]
	Transform [] waypoints;
	int wayPointIndex = 1;
    public float speed = 35f;
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position ,waypoints[wayPointIndex].position ,speed * Time.deltaTime);

		if (transform.position == waypoints[1].position ){
			wayPointIndex = 0;
            transform.localScale = new Vector2 (4f,4f);
		}else if (transform.position == waypoints[0].position){
			wayPointIndex = 1;
			transform.localScale = new Vector2 (-4f,4f);
        }
	}

  
    
}
