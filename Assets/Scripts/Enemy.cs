using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        List<Vector3> pathPoints = new List<Vector3>();
        pathPoints.Add(new Vector3(-10.41742f, -3.166969f));
        pathPoints.Add(new Vector3(0f, -3.203267f));
        pathPoints.Add(new Vector3(-0.01814912f, 2.640653f));
        pathPoints.Add(new Vector3(10.63521f, 2.640653f));

        rb = GetComponent<Rigidbody2D>();

        var follow = gameObject.AddComponent<FollowPath>();
        follow.StartFollowing(pathPoints, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}