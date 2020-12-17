using UnityEngine;

public class Staranimation : MonoBehaviour
{

    starmovemet myStarMovemetScript;
    void Awake()
    {
        myStarMovemetScript = GetComponent<starmovemet>();

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            myStarMovemetScript.enabled = true;
        }
    }

}
