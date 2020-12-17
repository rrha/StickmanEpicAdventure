using UnityEngine;

public class PassEnabled : MonoBehaviour
{
    public WanderScript upPass;
    public float time;
    void EnablePasses()
    {
        upPass.enabled = true;

    }

    void Awake()
    {
        Invoke("EnablePasses", time);
    }
}
