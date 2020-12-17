using UnityEngine;
using UnityEngine.UI;
public class MusicManager : MonoBehaviour
{

    AudioSource gameMusic;
    public Toggle musicToggle;
    float volume;
    public GameObject disableSign;
    public GameObject enableSign;

    void Awake()
    {
        gameMusic = GameObject.Find("Game Manager").GetComponent<AudioSource>();
        if (PlayerPrefs.GetFloat("Volume", 1) == 1)
        {
            gameMusic.volume = 0.4f;
            disableSign.SetActive(false);
            enableSign.SetActive(true);
        }
        else if (PlayerPrefs.GetFloat("Volume", 0) == 0)
        {
            gameMusic.volume = 0;
            disableSign.SetActive(true);
            enableSign.SetActive(false);
        }
    }

    public void Music()
    {
        if (!musicToggle.isOn)
        {
            gameMusic.volume = 0;
            PlayerPrefs.SetFloat("Volume", 0);
            PlayerPrefs.Save();
            disableSign.SetActive(true);
            enableSign.SetActive(false);
        }
        else if (musicToggle.isOn)
        {
            gameMusic.volume = 1;
            PlayerPrefs.SetFloat("Volume", 1);
            PlayerPrefs.Save();
            disableSign.SetActive(false);
            enableSign.SetActive(true);

        }

    }

}
