using UnityEngine;

public class ThornsManager : MonoBehaviour
{
    public float disableTime, enbaleTime;
    public SpriteRenderer gameObjectSprite;
    public PolygonCollider2D collider;

    void Awake()
    {
        InvokeRepeating("Enable", enbaleTime, 1);
        InvokeRepeating("Disable", disableTime, 1);
    }

    void Disable()
    {
        gameObjectSprite.enabled = false;
        collider.enabled = false;
    }
    void Enable()
    {
        gameObjectSprite.enabled = true;
        collider.enabled = true;

    }
}
