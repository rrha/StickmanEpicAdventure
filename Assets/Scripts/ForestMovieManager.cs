using UnityEngine;
using UnityStandardAssets._2D;

public class ForestMovieManager : MonoBehaviour
{
    public Platformer2DUserControl playerControl;
    public PlatformerCharacter2D character;
    public ForestBossManager monsterHandle;
    void Update()
    {
        Invoke("EnabledPlay", 4f);
    }
    void EnabledPlay()
    {
        playerControl.enabled = true;
        character.enabled = true;
        monsterHandle.enabled = true;
        Destroy(gameObject);
    }
}
