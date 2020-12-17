using UnityEngine;

public class EnablePasses : MonoBehaviour
{
    public WanderScript rightPass, middlePass, leftPass;
    public float time;
    void Enable()
    {
        rightPass.enabled = true;
        middlePass.enabled = true;
        leftPass.enabled = true;

    }

    void Awake()
    {
        Invoke("Enable", time);
    }
}
