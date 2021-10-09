using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour
{
    public EnemyPath path;
    Rigidbody2D rb;

    void Start()
    {
        List<Vector3> pathPoints = new List<Vector3>();
        pathPoints.Add(new Vector3(-10.41742f, -3.166969f));
        pathPoints.Add(new Vector3(0f, -3.203267f));
        pathPoints.Add(new Vector3(-0.01814912f, 2.640653f));
        pathPoints.Add(new Vector3(10.63521f, 2.640653f));

        path = new EnemyPath(pathPoints);
        rb = GetComponent<Rigidbody2D>();
        transform.position = path.pathPoints[0];
    }

    // Update is called once per frame
    void Update()
    {
        var dest = path.pathPoints[1];
        float newX = transform.position.x;
        float newY = transform.position.y;

        float amt = 0.01f;

        if (Math.Round(transform.position.x) != Math.Round(dest.x))
        {
            newX += (transform.position.x > dest.x) ? -amt : amt;
        }

        if (Math.Round(transform.position.y) != Math.Round(dest.y))
        {
            newY += (transform.position.y > dest.y) ? -amt : amt;
        }

        transform.position = new Vector3(newX, newY);
    }
}