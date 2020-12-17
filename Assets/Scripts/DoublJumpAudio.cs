using UnityEngine;

public class DoublJumpAudio : MonoBehaviour
{
    AudioSource doubleJump;
    void Start()
    {
        doubleJump = this.GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Player"))
        {
            doubleJump.Play();
        }
    }
}
