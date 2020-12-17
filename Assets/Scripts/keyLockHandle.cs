using UnityEngine;

public class keyLockHandle : MonoBehaviour
{
    public GameObject lockObject;
    public GameObject stickGirlLocked, StickGirlFree;

    public void EnableKeyHandle()
    {
        stickGirlLocked.SetActive(false);
        StickGirlFree.SetActive(true);
        lockObject.SetActive(false);
    }
}
