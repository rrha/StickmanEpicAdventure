using UnityEngine;

public class scaleGroundManager : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Player"))
        {
            anim.SetBool("PlayerArrive", true);
        }
    }
}
