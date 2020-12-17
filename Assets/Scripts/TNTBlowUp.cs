using UnityEngine;

public class TNTBlowUp : MonoBehaviour
{
    public GameObject fire;
    AudioSource explosion;
    void Start()
    {
        explosion = this.GetComponent<AudioSource>();
    }
    void EnableObject()
    {
        gameObject.SetActive(false);
    }
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Player"))
        {
            Invoke("EnableObject", 0.5f);
            fire.SetActive(true);
            explosion.Play();
        }

    }

}
