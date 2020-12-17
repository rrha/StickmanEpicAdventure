using UnityEngine;

public class CubeButtonAudio : MonoBehaviour
{
    AudioSource buttonAudio;
    float nextDamage = 0f;
    float NextDamageRate = 4f;
    void Start()
    {
        buttonAudio = this.GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Cube") && Time.time > nextDamage)
        {
            buttonAudio.Play();
            nextDamage = Time.time + NextDamageRate;
        }
    }
}
