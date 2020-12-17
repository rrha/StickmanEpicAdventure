using UnityEngine;

public class BossSawAudio : MonoBehaviour
{
    AudioSource sawSfx;
    void Start()
    {
        sawSfx = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (transform.position.y >= -24.06045f)
        {
            sawSfx.volume = 0.5f;
        }
        else if (transform.position.y <= -24.06045f)
        {
            sawSfx.volume = 0f;
        }
    }
}
