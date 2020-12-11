using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablePasses : MonoBehaviour {
	public WanderScript rightPass,middlePass,leftPass;
	public float time;

	// Use this for initialization
	void Enable () {
		rightPass.enabled =true;
		middlePass.enabled =true;
		leftPass.enabled =true;

	}

	// Update is called once per frame
	void Awake () {
		Invoke ("Enable",time);
	}
}
