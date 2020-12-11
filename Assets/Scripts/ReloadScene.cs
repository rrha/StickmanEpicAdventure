using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReloadScene : MonoBehaviour {
	public string sceneToReload;

   public void Reload()
    {
        SceneManager.LoadScene(sceneToReload);
        Time.timeScale = 1;
    }
   void OnCollisionEnter2D(Collision2D data)
   {
       if (data.gameObject.CompareTag("Player"))
       {
			SceneManager.LoadScene(sceneToReload, LoadSceneMode.Single);
       }
   }
}
