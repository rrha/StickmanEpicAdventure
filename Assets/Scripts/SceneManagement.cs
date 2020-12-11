using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class SceneManagement : MonoBehaviour {
	public string SceneName;
	public bool enableTiming = false;

	public void Load (){
		SceneManager.LoadScene (SceneName);
	
	}

	IEnumerator Start(){
		if (enableTiming == true){
		yield return new WaitForSeconds (8);
		SceneManager.LoadScene (SceneName);
		}
	}
	void OnCollisionEnter2D (Collision2D collisionData){
		if (collisionData.gameObject.CompareTag("Player")){
			SceneManager.LoadScene (SceneName);
		}
	}
}
