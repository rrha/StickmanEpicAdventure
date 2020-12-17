using UnityEngine;
using UnityEngine.UI;
public class MusicButtonScript : MonoBehaviour
{
    [SerializeField]
    AudioSource gameMusic;
    Toggle musicToggle;
    float volume;
    public GameObject disableSign;
    public GameObject enableSign;

    void Start()
    {
        musicToggle = gameObject.GetComponent<Toggle>();
    }

    public void Music()
    {
        if (!musicToggle.isOn)
        {
            gameMusic.volume = 0;
            PlayerPrefs.SetFloat("Volume", gameMusic.volume);
            disableSign.SetActive(true);
            enableSign.SetActive(false);
        }
        else if (musicToggle.isOn)
        {
            gameMusic.volume = 1;
            PlayerPrefs.SetFloat("Volume", gameMusic.volume);
            disableSign.SetActive(false);
            enableSign.SetActive(true);

        }
    }
}
