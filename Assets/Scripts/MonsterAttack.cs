using UnityEngine;

public class MonsterAttack : MonoBehaviour
{
    [SerializeField]
    Transform target;
    [SerializeField]
    float speed;
    Rigidbody2D rb;
    [SerializeField]
    Transform currentPoint;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (target.position.x > 530 && target.position.x < 1043)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.position.x, transform.position.y), speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, currentPoint.position, speed * Time.deltaTime);
        }
    }
}
