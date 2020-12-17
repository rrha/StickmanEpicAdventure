using UnityEngine;

public class HealthTracking : MonoBehaviour
{
    public Health myHealthScript;
    public GameObject currentCanvas, upComingCanvas;
    public int healthCounter = 3;
    Animator anim;
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }
    void Update()
    {
        if (myHealthScript.healthCounter == 1)
        {
            anim.SetBool("GoodToGo", true);
            currentCanvas.SetActive(true);
            upComingCanvas.SetActive(false);

        }
    }
}
