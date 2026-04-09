using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp;

    void Start()
    {
        hp = EnemyProfile.Instance.enemyHP;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}