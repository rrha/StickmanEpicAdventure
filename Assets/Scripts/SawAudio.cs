using UnityEngine;

public class SawAudio : MonoBehaviour
{

    AudioSource sawAudio;
    public Transform playerTrans;
    public float backPos, frontPos;
    void Start()
    {
        sawAudio = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (playerTrans.position.x > backPos && playerTrans.position.x < frontPos)
        {
            sawAudio.volume = 0.5f;
        }
        else if (playerTrans.position.x < backPos || playerTrans.position.x > frontPos)
        {
            sawAudio.volume = 0f;
        }
    }
}
