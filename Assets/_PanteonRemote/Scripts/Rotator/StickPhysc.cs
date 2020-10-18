using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickPhysc : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Character")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(transform.up * 50, ForceMode.Acceleration);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward*1000,ForceMode.Acceleration);             
        }
    }
}
