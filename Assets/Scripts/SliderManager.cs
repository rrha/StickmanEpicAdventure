using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour {

	public string LoadingSceneName;
	public Slider sliderBar;
	public Text counter;
	float progress;

	void LateUpdate (){
		counter.text = progress + "%";
		sliderBar.value = progress++;
		if (progress == 101){
			SceneManager.LoadScene(LoadingSceneName);
			progress = 100;
		}
	}


}
