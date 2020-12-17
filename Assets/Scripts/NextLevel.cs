using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public GameObject currentMenu;
    public GameObject upComingMenu;
    void OnTriggerEnter2D(Collider2D data)
    {
        if (data.gameObject.CompareTag("Player"))
        {
            currentMenu.SetActive(false);
            upComingMenu.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
