using UnityEngine;

public class FinalLevelManager : MonoBehaviour
{
    public GameObject nextLevel;
    public GameObject gamePlayButton;
    void Awake()
    {
        Time.timeScale = 1;
    }
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Player"))
        {
            nextLevel.SetActive(true);
            gamePlayButton.SetActive(false);
            Time.timeScale = 0;
        }
    }
}
