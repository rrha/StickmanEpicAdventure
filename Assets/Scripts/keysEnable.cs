using UnityEngine;

public class keysEnable : MonoBehaviour
{
    public GameObject leftKey, rightKey;
    void EnableKeys()
    {
        leftKey.SetActive(true);
        rightKey.SetActive(true);
    }

    void Awake()
    {
        Invoke("EnableKeys", 13f);
    }
}
