using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorRotating : MonoBehaviour
{
    public float cylinderRotSpeed = 200;
    float speed = 50f;
    public bool left = false;
    public bool right = false;
    float way;
    void Start()
    {
        if (left)
        {
            way = -1;
        }
        if (right)
        {
            way = 1;
        }
    }
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, way * Time.deltaTime * speed,0 ), cylinderRotSpeed * Time.deltaTime);
    }   
}
