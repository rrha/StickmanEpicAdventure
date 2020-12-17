using UnityEngine;

public class CactusHandle : MonoBehaviour
{
    public Transform endPoint;
    public float timeToInvoke;
    public float speed;
    void Update()
    {
        Invoke("MoveToEndPoint", timeToInvoke);
        if (transform.position.x == endPoint.position.x)
        {
            Destroy(gameObject);
        }
    }
    void MoveToEndPoint()
    {
        transform.position = Vector2.MoveTowards(transform.position, endPoint.position, speed);

    }

}
