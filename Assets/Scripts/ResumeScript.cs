using UnityEngine;

public class ResumeScript : MonoBehaviour
{
    public GameObject resumeCanvas, sliderManager, currentCanvas;

    public void Resume()
    {
        resumeCanvas.SetActive(true);
        sliderManager.SetActive(true);
        currentCanvas.SetActive(false);
    }
}
