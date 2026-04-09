using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] public static SpawnManager singleton;
    public bool canSpawn = true;

    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        }
        else
        {
            Destroy(this);
        }
    }
}
