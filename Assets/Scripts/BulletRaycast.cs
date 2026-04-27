using UnityEngine;

public class BulletRaycast : MonoBehaviour
{
    public Vector3 velocity;
    public float gravity = -9.8f;
    public float lifeTime = 5f;
    public LayerMask hitMask;

    private float timer = 0f;

    public void Init(Vector3 startVelocity)
    {
        velocity = startVelocity;
    }

    void Update()
    {
        float dt = Time.deltaTime;

        Vector3 startPos = transform.position;

        velocity += Vector3.up * gravity * dt;

        Vector3 nextPos = startPos + velocity * dt;

        Vector3 moveDir = nextPos - startPos;
        float moveDistance = moveDir.magnitude;

        if (moveDistance > 0f)
        {
            if (Physics.Raycast(startPos, moveDir.normalized, out RaycastHit hit, moveDistance, hitMask))
            {
                transform.position = hit.point;
                Debug.Log("Hit: " + hit.collider.name);
                Destroy(hit.collider.gameObject);
                Destroy(gameObject);
                return;
            }
        }

        transform.position = nextPos;

        if (velocity != Vector3.zero)
        {
            transform.forward = velocity.normalized;
        }

        timer += dt;
        if (timer >= lifeTime)
        {
            Destroy(gameObject);
        }
    }
}