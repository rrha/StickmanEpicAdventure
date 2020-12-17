using UnityEngine;

public class PlayerEnterNextLevel : MonoBehaviour
{
    public GameObject player;
    public GameObject showGameObject;
    public GameObject hideGameObject;
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Player"))
        {
            player.SetActive(false);
            showGameObject.SetActive(true);
            hideGameObject.SetActive(false);

        }
    }
}
