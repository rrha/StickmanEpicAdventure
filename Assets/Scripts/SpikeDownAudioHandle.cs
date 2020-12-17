using UnityEngine;

public class SpikeDownAudioHandle : MonoBehaviour
{
    float nextDamage = 0f;
    public float NextDamageRate = 1f;
    AudioSource sawAudio;
    public Transform playerTrans;
    public float backPos, frontPos;
    void Start()
    {
        sawAudio = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (playerTrans.position.x > backPos && playerTrans.position.x < frontPos && Time.time > nextDamage && playerTrans.position.y <= -40f)
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
