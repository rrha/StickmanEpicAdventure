using UnityEngine;

public class SecondPushButtonHandle : MonoBehaviour
{
    Animator anim;
    [SerializeField]
    GameObject pushGroundScale;
    bool pushed;
    [HideInInspector]
    public bool Onit = false;
    public PushedButtonHandle myScriptHandle;
    [HideInInspector]
    public bool active;

    void Start()
    {
        anim = this.GetComponent<Animator>();
        active = true;
    }


    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Player") && active)
        {
            pushGroundScale.SetActive(true);
            Invoke("NotPushed", 7f);
            Onit = true;
            myScriptHandle.Onit = false;
            myScriptHandle.active = true;
            active = false;
        }
    }
    void NotPushed()
    {
        pushGroundScale.SetActive(false);
    }

    void Update()
    {
        if (Onit)
        {
            anim.SetBool("Pushed", true);
        }
        else if (!Onit)
        {
            anim.SetBool("Pushed", false);
        }
    }

}
