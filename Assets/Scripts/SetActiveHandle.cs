using UnityEngine;

public class SetActiveHandle : MonoBehaviour
{
    public GameObject hideGameObject;
    public GameObject showGameObject;
    [SerializeField]
    public bool scaleTime = false;
    public bool destroy = false;
    [SerializeField]
    private AudioSource gameMusic;
    public bool enableMusic = true;
    [SerializeField]
    private string tagName;
    public bool disableSprite;
    SpriteRenderer sprite;
    CircleCollider2D collider;
    void Awake()
    {
        Time.timeScale = 1;
        if (disableSprite == true)
        {
            sprite = this.GetComponent<SpriteRenderer>();
            collider = this.GetComponent<CircleCollider2D>();

        }

    }
    public void Active()
    {
        hideGameObject.SetActive(false);
        showGameObject.SetActive(true);
        if (enableMusic == false)
        {
            gameMusic.enabled = false;
        }
        if (scaleTime == true)
        {
            Time.timeScale = 0;
        }
        else
        {

            Time.timeScale = 1;
        }
    }
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag(tagName))
        {
            hideGameObject.SetActive(false);
            showGameObject.SetActive(true);
            Time.timeScale = 0;
            if (destroy == true)
            {
                Destroy(gameObject);
            }
            if (disableSprite == true)
            {
                sprite.enabled = false;
                collider.enabled = false;
            }
        }

    }
}
