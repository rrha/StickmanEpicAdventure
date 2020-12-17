using UnityEngine;

public class ElevatorManager : MonoBehaviour
{
    public Transform[] elevatorPoints;
    public float speed;
    [HideInInspector]
    public bool move = false;
    int wayPointIndex;
    void FixedUpdate()
    {
        if (move)
        {
            transform.position = Vector2.MoveTowards(transform.position, elevatorPoints[wayPointIndex].position, speed * Time.deltaTime);
            if (transform.position == elevatorPoints[1].position)
            {
                wayPointIndex = 0;
                move = false;
            }
            else if (transform.position == elevatorPoints[0].position)
            {
                wayPointIndex = 1;
                move = false;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Player"))
        {
            move = true;
        }
    }
}
