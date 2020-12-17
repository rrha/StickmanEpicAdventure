using UnityEngine;

public class SpikesTranslation : MonoBehaviour
{
    public starmovemet myStartMovemntEnable, mySecondStartMovemntEnable;
    SpikesTranslation spikesMovement;
    void Start()
    {
        spikesMovement = this.GetComponent<SpikesTranslation>();
    }
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Player"))
        {
            mySecondStartMovemntEnable.enabled = true;
            myStartMovemntEnable.enabled = true;
            spikesMovement.enabled = false;

        }
    }
}
