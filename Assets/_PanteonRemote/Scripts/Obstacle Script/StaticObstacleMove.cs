using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class StaticObstacleMove : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating("TransformObstacle", 2, 10f);
    }
    void TransformObstacle()
    {
        transform.DOMoveX(transform.position.x+3f, 3f);
        Invoke("TransformObstacleOpposite", 5);
    }
    void TransformObstacleOpposite()
    {
        transform.DOMoveX(transform.position.x - 3f, 3f);
    }
}

