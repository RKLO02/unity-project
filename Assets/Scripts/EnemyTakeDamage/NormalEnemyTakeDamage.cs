using UnityEngine;

public class NormalEnemy : EnemyBase
{
    protected override int CalculateFinalDamage(int damage)
    {
        return damage;
    }

}