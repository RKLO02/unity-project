using UnityEngine;

public class EnemyOne : MonoBehaviour
{

    public static float maxHP = 10f;
    //public float currentHP = 10f;
    EnemyStatus enemyStatus;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class EnemyStatus
{
    public float currentHP;
    public float currentArmor;
}
