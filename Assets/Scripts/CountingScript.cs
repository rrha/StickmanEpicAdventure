using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountingScript : MonoBehaviour {
	[HideInInspector]
	public Text countingText;
	[HideInInspector]
	public int counter;
	void Start (){
		countingText = this.GetComponent<Text>();
	}

}
