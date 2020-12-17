using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    [SerializeField]
    Transform waypoint;
    public float speed = 35f;
    [SerializeField]
    Transform target;
    public float backDist;
    public float frontDist;
    public string tag;
    Rigidbody2D rb;
    public float jumpStrenght;

    void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void LateUpdate()
    {
        if (target.position.x > backDist && target.position.x < frontDist)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.position.x, transform.position.y), speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoint.position, speed * Time.deltaTime);
        }
    }
    void OnCollisionEnter2D(Collision2D data)
    {
        if (data.gameObject.CompareTag(tag))
        {
            rb.AddForce(Vector2.up * jumpStrenght, ForceMode2D.Impulse);
        }

    }
}
