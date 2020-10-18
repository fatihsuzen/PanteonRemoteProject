using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowCharacter : MonoBehaviour
{
   public GameObject character;
   Vector3 cameraOffSet;
   Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        Invoke("animatorActive", 10);
        cameraOffSet = new Vector3(0, 10, -10);
    }
    void Update()
    {
        transform.position = character.transform.position + cameraOffSet;
    }
    void animatorActive()
    {
        animator.enabled = false;
    }
}
