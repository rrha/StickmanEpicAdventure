using UnityEngine;

public class SingletonMusicHandle : MonoBehaviour
{

    public static SingletonMusicHandle Instance;
    public bool dontDestroyOnLoad = true;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            if (dontDestroyOnLoad)
            {
                DontDestroyOnLoad(this.gameObject);
            }
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
