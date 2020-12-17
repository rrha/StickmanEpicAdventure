using UnityEngine;

public class CavernScript : MonoBehaviour
{
    public Transform player;
    Rigidbody2D rb;
    [SerializeField]
    private float gravityScaleAverage;
    public float transformToProcedue;
    void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (player.position.x >= transformToProcedue)
        {
            rb.gravityScale = gravityScaleAverage;
        }
    }
}
