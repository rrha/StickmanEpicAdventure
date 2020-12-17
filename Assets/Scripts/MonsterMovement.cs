using UnityEngine;

public class MonsterMovement : MonoBehaviour
{

    [SerializeField]
    Transform[] waypoints;
    int wayPointIndex = 0;
    Rigidbody2D rb;
    Animator anim;
    public float jumpStrenght = 35f;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        transform.position = waypoints[1].position;
    }

    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, waypoints[wayPointIndex].position, speed * Time.deltaTime);

        if (transform.position == waypoints[0].position)
        {
            wayPointIndex = Random.Range(1, 2);
        }
        else if (transform.position == waypoints[1].position)
        {
            anim.SetBool("IsMoving", false);
            Invoke("MoveToOtherPoint", 6);
        }
        else if (transform.position == waypoints[2].position)
        {
            wayPointIndex = Random.Range(0, 1);
        }
    }

    void MoveToOtherPoint()
    {
        wayPointIndex = 2;
        anim.SetBool("IsMoving", true);

    }


    void OnCollisionEnter2D(Collision2D data)
    {
        if (data.gameObject.CompareTag("Ground"))
        {
            rb.AddForce(Vector2.up * jumpStrenght, ForceMode2D.Impulse);
        }

    }
}
