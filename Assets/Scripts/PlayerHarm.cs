using UnityEngine;

public class PlayerHarm : MonoBehaviour
{
    float nextDamage = 0f;
    float NextDamageRate = 1f;
    public HealthManager thePlayerHealth;
    Animator anim;

    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void Update()
    {
        if (thePlayerHealth.health <= 0)
        {
            anim.SetBool("Died", true);
        }
    }


    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Danger") && Time.time > nextDamage)
        {
            thePlayerHealth.addDamage(1);
            nextDamage = Time.time + NextDamageRate;

        }
    }
}
