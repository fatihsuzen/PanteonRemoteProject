using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Bot : MonoBehaviour
{
    public GameObject finish;
    float speed;
    NavMeshAgent nav;
    Vector3 target;
    Animator animator;
    bool update=false;
    void Start()
    {
        animator = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
        speed = Random.Range(4f, 7.5f);
        Invoke("StartAnim",0);
    }
    
    void StartAnim()
    {
        animator.SetInteger("status",-1);
        Invoke("StartUpdate", 10);//For camera animation delay
    }
    void StartUpdate()
    {
        update = true;
        animator.SetInteger("status", 1);
    }
    void FixedUpdate()
    {
        if(update)
        {
            target = finish.transform.position - transform.position;
            Vector3.Angle(target, transform.forward * Time.deltaTime);
            nav.speed = speed;
            nav.SetDestination(finish.transform.position);
        }
       
    }
}
