using UnityEngine;

public class PushButton : MonoBehaviour
{
    public Animator scaleGroundAnimator;
    Animator anim;
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Player"))
        {
            scaleGroundAnimator.enabled = true;
            anim.SetBool("Pushed", true);
        }
    }
}
