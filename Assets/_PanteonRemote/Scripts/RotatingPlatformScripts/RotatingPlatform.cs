using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    public float force;
    public Rigidbody rb;
    private void FixedUpdate()
    {
        rb.angularVelocity = Vector3.forward * force;        
    }
}
