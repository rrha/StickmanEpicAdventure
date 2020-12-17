using UnityEngine;

public class FishManager : MonoBehaviour
{
    public Transform[] fishWayPoints;
    public float speed = 10;
    int wayPointIndex;

    void Start()
    {
        transform.position = fishWayPoints[1].position;

    }

    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, fishWayPoints[wayPointIndex].position, speed * Time.deltaTime);
        if (transform.position.y == fishWayPoints[1].position.y)
        {
            wayPointIndex = 0;
            Vector3 Fishrotation = new Vector3(0, 0, 90);
            transform.rotation = Quaternion.Euler(Fishrotation);
        }
        else if (transform.position.y == fishWayPoints[0].position.y)
        {
            wayPointIndex = 1;
            Vector3 Fishrotation = new Vector3(0, 0, -90);
            transform.rotation = Quaternion.Euler(Fishrotation);
        }
    }
}
