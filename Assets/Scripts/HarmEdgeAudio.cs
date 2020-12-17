using UnityEngine;

public class HarmEdgeAudio : MonoBehaviour
{
    float nextDamage = 0f;
    float NextDamageRate = 1f;
    public Transform playerTrans;
    public float backPos, frontPos;
    AudioSource harmEdgeSfx;

    void Start()
    {
        harmEdgeSfx = this.GetComponent<AudioSource>();
    }
    void Update()
    {
        if (playerTrans.position.x > backPos && playerTrans.position.x < frontPos && transform.position.y >= -18.22f && Time.time > nextDamage)
        {
            harmEdgeSfx.Play();
            nextDamage = Time.time + NextDamageRate;
        }
    }
}
