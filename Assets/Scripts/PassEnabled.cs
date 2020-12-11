using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassEnabled : MonoBehaviour {
	public WanderScript upPass;
	public float time;
	// Use this for initialization
	void EnablePasses () {
		upPass.enabled =true;

	}

	// Update is called once per frame
	void Awake () {
		Invoke ("EnablePasses",time);
	}
}
