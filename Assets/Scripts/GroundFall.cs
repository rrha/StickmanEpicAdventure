using UnityEngine;

public class GroundFall : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D data)
    {
        if (data.gameObject.CompareTag("Player"))
        {
            rb.gravityScale = speed;
            Invoke("DestroyObject", 2);
        }
    }
    void DestroyObject()
    {
        Destroy(gameObject);

    }
}
