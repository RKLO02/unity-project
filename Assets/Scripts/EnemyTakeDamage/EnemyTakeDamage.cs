using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    [Header("Enemy Information")]
    public string enemyName = "Enemy";
    public int maxHp = 100;

    protected int currentHp;

    private void Start()
    {
        currentHp = maxHp;
    }

    public void TakeDamage(int damage)
    {
        if (currentHp <= 0)
        {
            return;
        }

        int finalDamage = CalculateFinalDamage(damage);

        currentHp -= finalDamage;

        if (currentHp < 0)
        {
            currentHp = 0;
        }

        OnAfterTakeDamage(finalDamage);

        if (currentHp <= 0)
        {
            Die();
        }
    }

    protected abstract int CalculateFinalDamage(int damage);

    protected virtual void OnAfterTakeDamage(int finalDamage)
    {
        
    }

    protected virtual void Die()
    {
        Destroy(gameObject);
    }
}