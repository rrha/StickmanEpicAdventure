using UnityEngine;

public class SpiderHandle : MonoBehaviour
{
    [SerializeField]
    Transform[] waypoints;
    int wayPointIndex = 1;
    public float speed = 35f;
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints[wayPointIndex].position, speed * Time.deltaTime);

        if (transform.position == waypoints[1].position)
        {
            wayPointIndex = 0;
            transform.localScale = new Vector2(2.5f, 2.5f);
        }
        else if (transform.position == waypoints[0].position)
        {
            wayPointIndex = 1;
            transform.localScale = new Vector2(2.5f, -2.5f);
        }
    }


}
