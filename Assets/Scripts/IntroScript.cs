using System.Collections;
using UnityEngine;

public class IntroScript : MonoBehaviour
{
    public GameObject menuCanvas, gameManager;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(8);
        Intro();
    }

    void Intro()
    {
        gameObject.SetActive(true);
        menuCanvas.SetActive(true);
        gameManager.SetActive(true);
    }
}
