using UnityEngine;

public class EnablePlaying : MonoBehaviour
{
    public MineVehicleMovement myMineScriptMovement;
    public TargetFollow myTargetFollow;
    public MonsterManager myMonsterScript;
    void Awake()
    {
        myMonsterScript.enabled = false;
        myTargetFollow.enabled = false;
        myMineScriptMovement.enabled = false;
    }
    void Update()
    {
        Invoke("Enbale", 4f);
    }
    void Enbale()
    {
        myMineScriptMovement.enabled = true;
        myTargetFollow.enabled = true;
        myMonsterScript.enabled = true;
    }
}
