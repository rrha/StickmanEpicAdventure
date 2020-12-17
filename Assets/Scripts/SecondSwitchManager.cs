using UnityEngine;

public class SecondSwitchManager : MonoBehaviour
{
    public GameObject ropeDoor;
    Animator anim;
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Player"))
        {
            anim.SetBool("On", true);
            ropeDoor.SetActive(false);
            Invoke("EnableRopeDoor", 17f);
        }
    }
    void EnableRopeDoor()
    {
        ropeDoor.SetActive(true);
        anim.SetBool("On", false);

    }

}
