using UnityEngine;

public class ShotPlayer : MonoBehaviour
{
    public float xAxis, yAxis, zAxis, speed, time;
    public Transform endPoint;

    void Awake()
    {
        InvokeRepeating("CreateObjects", time, 0f);
    }

    void Start()
    {
        Vector3 Fishrotation = new Vector3(0, 0, zAxis);
        transform.rotation = Quaternion.Euler(Fishrotation);
    }
    void CreateObjects()
    {
        Instantiate(this.gameObject, new Vector2(xAxis, yAxis), Quaternion.identity);

    }
    void Update()
    {
        Invoke("Move", 1f);
        if (endPoint.position == transform.position)
        {
            Destroy(gameObject);
        }

    }
    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, endPoint.position, speed * Time.deltaTime);
    }
}
