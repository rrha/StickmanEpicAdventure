using UnityEngine;

public class MountaneFollow : MonoBehaviour
{
    public Transform target;
    void Start()
    {

    }

    void LateUpdate()
    {
        transform.position = new Vector2(target.position.x, transform.position.y);
    }
}
