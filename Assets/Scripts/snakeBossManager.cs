using UnityEngine;

public class snakeBossManager : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Cube"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
