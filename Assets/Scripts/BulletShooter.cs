using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 15f;
    public float upAngle = 0.3f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bulletObj = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        BulletRaycast bullet = bulletObj.GetComponent<BulletRaycast>();
        if (bullet != null)
        {
            Vector3 dir = (firePoint.forward + Vector3.up * upAngle).normalized;
            bullet.Init(dir * bulletSpeed);
        }
    }
}