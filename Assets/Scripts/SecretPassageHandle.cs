using UnityEngine;

public class SecretPassageHandle : MonoBehaviour
{
    public Transform PlayerTrans;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);

        }
    }
}
