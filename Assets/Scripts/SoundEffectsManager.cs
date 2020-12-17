using UnityEngine;
using UnityEngine.UI;
public class SoundEffectsManager : MonoBehaviour
{
    [SerializeField] private AudioSource sFX1;
    [SerializeField] private AudioSource sFX2;
    [SerializeField] private AudioSource sFX3;
    [SerializeField] private AudioSource sFX4;
    [SerializeField] private AudioSource sFX5;
    [SerializeField] private AudioSource sFX6;
    [SerializeField] private AudioSource sFX7;
    [SerializeField] private AudioSource sFX8;
    [SerializeField] private AudioSource sFX9;


    public Toggle musicToggle;

    void Awake()
    {
        if (PlayerPrefs.GetFloat("Volume") == 0)
        {
            sFX1.volume = 0;
            sFX2.volume = 0;
            sFX3.volume = 0;
            sFX4.volume = 0;
            sFX5.volume = 0;
            sFX6.volume = 0;
            sFX7.volume = 0;
            sFX8.volume = 0;
            sFX9.volume = 0;


        }
        else if (PlayerPrefs.GetFloat("Volume") == 1)
        {
            sFX1.volume = 1;
            sFX2.volume = 1;
            sFX3.volume = 1;
            sFX4.volume = 1;
            sFX5.volume = 1;
            sFX6.volume = 1;
            sFX7.volume = 1;
            sFX8.volume = 1;
            sFX9.volume = 1;

        }


    }

    public void DisbaleSFX()
    {
        if (!musicToggle.isOn)
        {
            sFX1.volume = 0;
            sFX2.volume = 0;
            sFX3.volume = 0;
            sFX4.volume = 0;
            sFX5.volume = 0;
            sFX6.volume = 0;
            sFX7.volume = 0;
            sFX8.volume = 0;
            sFX9.volume = 0;

        }
        else if (musicToggle.isOn)
        {
            sFX1.volume = 1;
            sFX2.volume = 1;
            sFX3.volume = 1;
            sFX4.volume = 1;
            sFX5.volume = 1;
            sFX6.volume = 1;
            sFX7.volume = 1;
            sFX8.volume = 1;
            sFX9.volume = 1;
        }

    }
}
