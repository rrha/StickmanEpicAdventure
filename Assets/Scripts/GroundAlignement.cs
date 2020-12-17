using UnityEngine;

public class GroundAlignement : MonoBehaviour
{
    public GameObject groundSpot;
    void Update()
    {
        this.transform.position = groundSpot.transform.position;
    }

}
