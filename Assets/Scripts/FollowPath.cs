using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public float moveSpeed = 1;
    public Queue<Vector2> pathPoints = new Queue<Vector2>();

    void Update()
    {
        if (pathPoints.Count == 0)
            return;

        var dest = pathPoints.Peek();
        bool reachedX = Math.Round(transform.position.x) == Math.Round(dest.x);
        bool reachedY = Math.Round(transform.position.y) == Math.Round(dest.y);

        if (reachedX) transform.position = new Vector2(dest.x, transform.position.y);
        if (reachedY) transform.position = new Vector2(transform.position.x, dest.y);

        if (reachedX && reachedY)   
        {
            dest = pathPoints.Dequeue();
        }

        float newX = transform.position.x;
        float newY = transform.position.y;

        float amt = moveSpeed * Time.deltaTime;

        if (!reachedX)
        {
            newX += (transform.position.x > dest.x) ? -amt : amt;
        }

        if (!reachedY)
        {
            newY += (transform.position.y > dest.y) ? -amt : amt;
        }

        transform.position = new Vector3(newX, newY);
    }

    public void StartFollowing(List<Vector2> points, bool moveToStart)
    {
        pathPoints.Clear();
        foreach (var point in points)
            pathPoints.Enqueue(point);

        if (moveToStart)
            transform.position = pathPoints.Peek();
    }
}
