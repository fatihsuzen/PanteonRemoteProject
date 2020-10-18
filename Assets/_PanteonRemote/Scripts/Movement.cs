using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public DynamicJoystick dynamicJoystick;
    public float speed;
    Animator animator;
    Rigidbody rb;
    Vector3 inputVector;
    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {      
        if ((dynamicJoystick.Horizontal != 0 || dynamicJoystick.Vertical != 0) && dynamicJoystick.isActiveAndEnabled)
        {
            if (Input.GetMouseButton(0))
            {
                inputVector = new Vector3(dynamicJoystick.Horizontal * 10, rb.velocity.y, speed);
                transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));
                animator.SetInteger("status", 1);
            }
            animator.SetInteger("status", 1);
        }
        else
        {
            inputVector = Vector3.zero;
            transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));
            animator.SetInteger("status", -1);
        }
        
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector3(inputVector.x, rb.velocity.y, inputVector.z);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="RotatingPlatform" || collision.collider.tag == "Rotator")
        {
            rb.freezeRotation = false;
        }
        else
        {
            rb.freezeRotation = true;
        }
    }
}