using UnityEngine;

public class ArmoredEnemy : EnemyBase
{
    protected override int CalculateFinalDamage(int damage)
    {
        return Mathf.RoundToInt(damage * 0.5f);
    }

    protected override void OnAfterTakeDamage(int finalDamage)
    {
    }
}