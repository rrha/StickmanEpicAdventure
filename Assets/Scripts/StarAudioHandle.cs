using UnityEngine;

public class StarAudioHandle : MonoBehaviour
{
    AudioSource buttonAudio;
    void Start()
    {
        buttonAudio = this.GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Player"))
        {
            buttonAudio.Play();
        }
    }
}
