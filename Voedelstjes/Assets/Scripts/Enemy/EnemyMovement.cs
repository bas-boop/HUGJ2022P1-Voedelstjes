using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform pointA, pointB;
    [SerializeField] private Vector3 currentTarget;

    private void Update()
    {
        if (transform.position == pointA.position)
        {
            currentTarget = pointB.position;
        }else if (transform.position == pointB.position)
        {
            currentTarget = pointA.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);
    }
}
