using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public GameObject currentMenu;
    public GameObject upComingMenu;
    void OnCollisionEnter2D(Collision2D data)
    {
        if (data.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            currentMenu.SetActive(false);
            upComingMenu.SetActive(true);
        }
    }
}
