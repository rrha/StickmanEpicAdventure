using UnityEngine;

public class payramideMonsterFlipHandle : MonoBehaviour
{
    public Transform playerTrans;
    SpriteRenderer flipSprite;
    void Start()
    {
        flipSprite = this.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (playerTrans.position.x > 1030)
        {
            flipSprite.flipX = true;
        }
        else if (playerTrans.position.x > 1007 && playerTrans.position.x < 1030)
        {
            flipSprite.flipX = false;

        }
    }
}
