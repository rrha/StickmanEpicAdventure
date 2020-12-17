using UnityEngine;

public class starmovemet : MonoBehaviour
{
    [SerializeField]
    Transform star;
    [SerializeField]
    float speed;
    bool canMove = true;
    void Update()
    {
        if (canMove)
        {
            transform.position = Vector2.MoveTowards(transform.position, star.position, speed);
        }
        if (Time.timeScale == 0)
        {
            canMove = false;
        }
        else if (Time.timeScale == 1)
        {
            canMove = true;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("END"))
        {
            Destroy(gameObject);

        }
    }
    void OnCollisionEnter2D(Collision2D collsionData)
    {
        if (collsionData.gameObject.CompareTag("END"))
        {
            Destroy(gameObject);
        }
    }
}
