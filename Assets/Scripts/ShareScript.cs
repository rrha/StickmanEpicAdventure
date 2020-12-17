using UnityEngine;

public class ShareScript : MonoBehaviour
{
    public GameObject copiedText;

    public void Share()
    {
        TextEditor te = new TextEditor();
        te.content = new GUIContent("this game is AWESOME !! check it out ");
        te.SelectAll();
        te.Copy();
        copiedText.SetActive(true);
        Invoke("DactivateText", 2);
    }
    void DactivateText()
    {

        copiedText.SetActive(false);

    }
}
