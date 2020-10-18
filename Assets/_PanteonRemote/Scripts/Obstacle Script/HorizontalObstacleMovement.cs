using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HorizontalObstacleMovement : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating("TransformObstacle", 2, 15f); 
    }
    void TransformObstacle()
    {
        transform.DOMoveX(transform.position.x * -1f, 15f);
    }

}
