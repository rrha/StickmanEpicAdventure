using UnityEngine;

public class SpikePopsUPHandle_ : MonoBehaviour
{

    public WanderScript myWanderScript;
    public Animator anim;

    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Player"))
        {
            anim.enabled = true;
            Invoke("DisableAnimator", 1f);
        }
    }
    void DisableAnimator()
    {
        anim.enabled = false;
        myWanderScript.enabled = true;
        this.gameObject.SetActive(false);
    }
}
