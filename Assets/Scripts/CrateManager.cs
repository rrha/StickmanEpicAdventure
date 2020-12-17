using UnityEngine;

public class CrateManager : MonoBehaviour
{
    public GameObject monster;
    public GameObject harmCactus;
    Rigidbody2D rb;
    bool enbaleGravity = false;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (enbaleGravity)
        {
            rb.gravityScale = 4f;
        }
    }
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Danger"))
        {
            enbaleGravity = true;
            monster.SetActive(false);
            harmCactus.SetActive(false);

        }
        else if (collisionData.gameObject.CompareTag("Ground"))
        {
            rb.constraints &= ~RigidbodyConstraints2D.FreezePositionY;
            rb.constraints &= ~RigidbodyConstraints2D.FreezePositionX;
        }
    }
}
