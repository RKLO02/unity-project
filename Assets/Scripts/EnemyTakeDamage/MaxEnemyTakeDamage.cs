using UnityEngine;

public class MaxEnemyTakeDamage : EnemyBase
{
    protected override int CalculateFinalDamage(int damage)
    {
        return 0;
    }

    protected override void OnAfterTakeDamage(int finalDamage)
    {
    }
}