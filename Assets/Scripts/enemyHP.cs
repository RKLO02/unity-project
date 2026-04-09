using UnityEngine;

public class EnemyProfile : MonoBehaviour
{
    public static EnemyProfile Instance;

    public int enemyHP = 10;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}