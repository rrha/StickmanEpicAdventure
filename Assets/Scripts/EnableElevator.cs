using UnityEngine;

public class EnableElevator : MonoBehaviour
{
    public GameObject spikeMonsterLeft, spikeMonsterRight;
    public WanderScript elevatorScript;
    void Start()
    {

    }

    void Update()
    {
        if (!spikeMonsterLeft.activeInHierarchy && !spikeMonsterRight.activeInHierarchy)
        {
            elevatorScript.enabled = true;
        }
    }
}
