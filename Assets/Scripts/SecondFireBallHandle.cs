using System.Collections.Generic;
using UnityEngine;

public class SecondFireBallHandle : MonoBehaviour {
	[SerializeField]
	Transform [] waypoints ;
	int wayPointIndex = 1;
	public float speed =10;

	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position ,waypoints[wayPointIndex].position ,speed * Time.deltaTime);
		if (transform.position == waypoints[0].position){
			Vector3 fireRotation = new Vector3 (0,0,-180);
			transform.rotation = Quaternion.Euler (fireRotation);
			wayPointIndex = 1;
		}else if (transform.position == waypoints[1].position){
			Vector3 fireRotation = new Vector3 (0,0,-90);
			transform.rotation = Quaternion.Euler (fireRotation);
			wayPointIndex = 2;
		}else if (transform.position == waypoints[2].position){
			Vector3 fireRotation = new Vector3 (0,0,0);
			transform.rotation = Quaternion.Euler (fireRotation);
			wayPointIndex = 3;
		}else if (transform.position == waypoints[3].position){
			Vector3 fireRotation = new Vector3 (0,0,90);
			transform.rotation = Quaternion.Euler (fireRotation);
			wayPointIndex = 0;
		}
	}
}
