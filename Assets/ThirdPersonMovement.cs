using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5f;

    float h, v;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        Vector3 dir = new Vector3(h, 0, v).normalized;

        rb.MovePosition(rb.position + dir * speed * Time.fixedDeltaTime);
    }
}