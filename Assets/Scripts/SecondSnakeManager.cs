using UnityEngine;

public class SecondSnakeManager : MonoBehaviour
{
    public float backTrans, frontDist, SecondFrontDist;
    public Transform playerTrans;
    void Update()
    {
        if (playerTrans.position.x >= backTrans && playerTrans.position.x < frontDist)
        {
            transform.localScale = new Vector2(7, 7);
        }
        else if (playerTrans.position.x > SecondFrontDist)
        {
            transform.localScale = new Vector2(-7, 7);
        }
    }
}
