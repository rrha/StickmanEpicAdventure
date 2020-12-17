using UnityEngine;

public class MineButtonHandle : MonoBehaviour
{
    public ElevatorManager myElevatorScript;
    Animator anim;
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Cube"))
        {
            myElevatorScript.move = true;
            anim.SetBool("Onit", true);
        }
    }
}
