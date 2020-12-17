using UnityEngine;

public class DoubleJumpHandle : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpStrenght;
    Animator anim;

    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void OnCollision2nter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Player"))
        {
            rb.AddForce(Vector2.up * jumpStrenght);
            anim.enabled = true;
            Invoke("DisableAnimator", 4f);
        }
    }

    void DisableAnimator()
    {
        anim.enabled = false;
    }
}
