using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnStart : MonoBehaviour
{   
    public void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = Vector3.zero;        
    }
}
