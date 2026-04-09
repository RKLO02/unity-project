using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thridpersonmovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public Rigidbody rb;
    Vector3 direction;

    public float speed = 6f;


    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f){
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            //controller.Move(direction * speed * Time.deltaTime);
            //rb.MovePosition(direction * speed * Time.deltaTime);

        }
    }

    void FixedUpdate() {
        rb.MovePosition(direction * speed * Time.deltaTime);
    }
}
