using UnityEngine;

public class RopeManager : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float force = 35f;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Invoke("Hing", 5);
    }

    void Hing()
    {

        rb.AddForce(Vector2.down * force);
    }

}
