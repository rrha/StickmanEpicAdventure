using UnityEngine;

public class MonsterWayPointchange : MonoBehaviour
{
    public Transform playerTrans;
    void Update()
    {
        if (playerTrans.position.x <= 1456f)
        {
            transform.position = new Vector2(1542f, transform.position.y);

        }
        else if (playerTrans.position.x >= 1540f)
        {
            transform.position = new Vector2(1457f, transform.position.y);
        }
    }
}
