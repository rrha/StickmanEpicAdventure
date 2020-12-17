using UnityEngine;

public class AppearAudioHandle : MonoBehaviour
{
    float nextDamage = 0f;
    public float NextDamageRate = 1f;
    AudioSource sawAudio;
    public Transform playerTrans;
    public float backPos, frontPos;
    public float height;
    void Start()
    {
        sawAudio = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (playerTrans.position.x > backPos && playerTrans.position.x < frontPos && Time.time > nextDamage && transform.position.y > height)
        {
            sawAudio.Play();
            nextDamage = Time.time + NextDamageRate;
        }
        else if (playerTrans.position.x < backPos || playerTrans.position.x > frontPos)
        {
            sawAudio.Stop();

        }
    }
}
