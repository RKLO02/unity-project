using UnityEngine;
//using UnityEngine.


public class PlayerShoot : MonoBehaviour
{
    public Camera shootCam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            Physics.Raycast(shootCam.transform.position, shootCam.transform.forward, out hitInfo, 100f);
            
            if(hitInfo.collider != null)
            {
                if (hitInfo.collider.CompareTag("Enemy"))
                {
                    if (hitInfo.collider.TryGetComponent<Enemy>(out Enemy enemy))
                    {
                        enemy.TakeDamage(5);
                        Debug.Log("Enemy Shot!");
                    }
                }
            }
        }
    }
}
