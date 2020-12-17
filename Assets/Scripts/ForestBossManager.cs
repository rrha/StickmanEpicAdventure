using UnityEngine;

public class ForestBossManager : MonoBehaviour
{
    [SerializeField]
    Transform waypoint;
    public float speed = 35f;
    [SerializeField]
    private Transform target;
    public float backDist;
    public float frontDist;
    public string tag;
    Rigidbody2D rb;
    public float jumpStrenght;
    Animator anim;
    bool canMove = true;
    public float health = 5;
    public Animator[] heartAnimation;
    float nextDamage = 0f;
    float NextDamageRate = 4.5f;
    public GameObject nextlevelKey;
    ForestBossManager myForestBossManager;

    void Awake()
    {

        Time.timeScale = 1;
        anim = this.GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody2D>();
        myForestBossManager = this.GetComponent<ForestBossManager>();
    }

    void LateUpdate()
    {
        if (health <= 0)
        {
            health = 0;
        }
        if (target.position.x > backDist && target.position.x < frontDist && canMove)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.position.x, transform.position.y), speed * Time.deltaTime);
        }
        else if (canMove)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoint.position, speed * Time.deltaTime);
        }
    }


    public void addDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            health = 0;
        }
        if (health == 4)
        {
            heartAnimation[0].enabled = true;
        }
        if (health == 3)
        {
            heartAnimation[1].enabled = true;
        }
        if (health == 2)
        {
            heartAnimation[2].enabled = true;
        }
        if (health == 1)
        {
            heartAnimation[3].enabled = true;
        }
        if (health == 0)
        {
            heartAnimation[4].enabled = true;
            anim.SetBool("Losed", true);
            nextlevelKey.SetActive(true);
            myForestBossManager.enabled = false;
        }
    }

    void OnCollisionEnter2D(Collision2D data)
    {
        if (data.gameObject.CompareTag(tag) && canMove)
        {
            rb.AddForce(Vector2.up * jumpStrenght, ForceMode2D.Impulse);
        }
        else if (data.gameObject.CompareTag("Danger") && Time.time > nextDamage)
        {
            addDamage(1);
            nextDamage = Time.time + NextDamageRate;
        }

    }
}
