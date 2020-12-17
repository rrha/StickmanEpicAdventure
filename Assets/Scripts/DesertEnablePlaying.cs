using UnityEngine;
using UnityStandardAssets._2D;

public class DesertEnablePlaying : MonoBehaviour
{
    public Platformer2DUserControl myUserControlScript;
    public GameObject cactusLeft;
    public GameObject cactusRight;
    void Update()
    {
        Invoke("DisableMovieEdges", 4f);
    }
    void DisableMovieEdges()
    {
        myUserControlScript.enabled = true;
        cactusLeft.SetActive(true);
        cactusRight.SetActive(true);
    }
}
