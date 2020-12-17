using UnityEngine;

public class ElevatorGearRotation : MonoBehaviour
{
    public Transform elevatorTrans;
    public Transform[] elevatorPoints;
    Animator anim;
    bool up = false;
    bool down = false;
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void Update()
    {
        if (elevatorTrans.position == elevatorPoints[1].position)
        {
            anim.SetBool("Idle", true);
            anim.SetBool("Down", false);
            anim.SetBool("Up", false);
            down = true;
            up = false;
        }
        else if (elevatorTrans.position == elevatorPoints[0].position)
        {
            anim.SetBool("Idle", true);
            anim.SetBool("Down", false);
            anim.SetBool("Up", false);
            up = true;
            down = false;
        }
        else if (elevatorTrans.position.y > elevatorPoints[0].position.y && up)
        {
            anim.SetBool("Idle", false);
            anim.SetBool("Down", false);
            anim.SetBool("Up", true);
        }
        else if (elevatorTrans.position.y < elevatorPoints[1].position.y && down)
        {
            anim.SetBool("Idle", false);
            anim.SetBool("Down", true);
            anim.SetBool("Up", false);
        }
    }
}
