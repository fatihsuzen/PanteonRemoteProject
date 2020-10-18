using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ObstacleMoveUpDown : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating("TransformObstacleUp", 6, 12f);        
    }
    void TransformObstacleUp()
    {
        transform.DOMoveY(2.5f, 3f);
        Invoke("TransformObstacleDown",6f);
    }
    void TransformObstacleDown()
    {
        transform.DOMoveY(-2.5f, 3f);
    }
}
