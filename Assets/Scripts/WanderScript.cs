using UnityEngine;

public class WanderScript : MonoBehaviour
{
    [SerializeField]
    Transform[] waypoints;
    int wayPointIndex = 1;
    public float speed = 10;
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints[wayPointIndex].position, speed * Time.deltaTime);
        if (transform.position == waypoints[1].position)
        {
            wayPointIndex = 0;
        }
        else if (transform.position == waypoints[0].position)
        {
            wayPointIndex = 1;
        }
    }
}
