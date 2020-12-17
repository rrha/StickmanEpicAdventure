using UnityEngine;

public class SwitchManager : MonoBehaviour
{
    Animator anim;
    public Animator ropeScale;
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Player"))
        {
            anim.SetBool("On", true);
            ropeScale.enabled = true;
        }
    }
}
