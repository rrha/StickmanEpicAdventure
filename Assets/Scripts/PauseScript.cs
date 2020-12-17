using UnityEngine;

public class PauseScript : MonoBehaviour
{

    public GameObject[] buttons;

    public void Pause()
    {
        buttons[0].SetActive(false);
        buttons[1].SetActive(true);
        Time.timeScale = 0;
    }
}
