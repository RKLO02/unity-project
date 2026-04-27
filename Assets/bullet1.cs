using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    [Header("Damage")]
    public int damage = 20;

    [Header("LifeTime")]
    public float lifeTime = 3f;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        EnemyBase enemy = collision.collider.GetComponent<EnemyBase>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Debug.Log("Hit" + enemy.name);
        }

        Destroy(gameObject);
    }
}