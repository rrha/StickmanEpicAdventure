using UnityEngine;

public class EachLevelGameMusicHandle : MonoBehaviour
{
    AudioSource gameManagerAudio;
    void Start()
    {
        gameManagerAudio = GameObject.Find("Game Manager").GetComponent<AudioSource>();
    }
    void Update()
    {
        DontDestroyOnLoad(gameObject);
        if (gameManagerAudio.isPlaying)
        {
            gameObject.SetActive(false);
        }
        else if (!gameManagerAudio.isPlaying)
        {
            gameObject.SetActive(true);
        }

    }
}
