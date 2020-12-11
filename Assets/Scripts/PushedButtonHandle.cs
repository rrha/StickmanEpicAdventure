using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushedButtonHandle : MonoBehaviour {
	Animator anim;
	[SerializeField]
	GameObject pushGroundScale;
	bool pushed;
	[HideInInspector]
	public bool Onit = false;
	public SecondPushButtonHandle myScriptHandle;
	[HideInInspector]
	public bool active;

	void Start (){
		anim = this.GetComponent<Animator> ();
		active = true;
	}


	void OnCollisionEnter2D (Collision2D collisionData){
		if (collisionData.gameObject.CompareTag ("Player") && active) {
			pushGroundScale.SetActive (true);
			Invoke ("NotPushed",7f);
			myScriptHandle.Onit = false;
			myScriptHandle.active = true;
			Onit = true;
			active = false;
		} 



	}
	void NotPushed (){
		pushGroundScale.SetActive (false);
	}

	void Update (){
		if (Onit) {
			anim.SetBool ("Pushed", true);
		} else if (!Onit) {
			anim.SetBool ("Pushed", false);
		}
	}

}
