using UnityEngine;

public class Water : MonoBehaviour
{
    AudioSource waterEffect;
    float nextDamage = 0f;
    float NextDamageRate = 1.5f;

    void Start()
    {
        waterEffect = this.GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && Time.time > nextDamage)
        {
            nextDamage = Time.time + NextDamageRate;
            waterEffect.Play();
        }
    }
}
