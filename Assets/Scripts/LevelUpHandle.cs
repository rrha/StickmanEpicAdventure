using UnityEngine;

public class LevelUpHandle : MonoBehaviour
{
    public GameObject[] snakes;
    public GameObject nextLevelKey;

    void Update()
    {
        if (!snakes[0].activeInHierarchy && !snakes[1].activeInHierarchy && nextLevelKey != null)
        {
            nextLevelKey.SetActive(true);
        }
    }
}
