using UnityEngine;

public class ThirdButtonHandle : MonoBehaviour
{
    public Rigidbody2D rb;
    Animator anim;

    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Player"))
        {
            rb.gravityScale = 1;
            anim.SetBool("Fall", true);
        }
    }
}