using UnityEngine;

public class FinalLevelKeyHandle : MonoBehaviour
{
    public Transform keyLock;
    bool move = false;
    keyLockHandle myKeyLockHandle;
    void Start()
    {
        myKeyLockHandle = this.GetComponent<keyLockHandle>();
    }
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Player"))
        {
            move = true;
            Invoke("DisableKey", 2f);
        }
    }
    void DisableKey()
    {
        gameObject.SetActive(false);
    }
    void Update()
    {
        if (move)
        {
            transform.position = Vector2.MoveTowards(transform.position, keyLock.position, 2f);
        }
        if (transform.position == keyLock.position)
        {
            myKeyLockHandle.EnableKeyHandle();
        }
    }

}
