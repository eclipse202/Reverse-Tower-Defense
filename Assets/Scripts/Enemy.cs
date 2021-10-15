using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour
{
    public EnemyInfo enemyInfo;
    public double health;

    private void Start()
    {
        health = enemyInfo.health;
    }

    public void FollowPath(PathInfo path)
    {
        var follow = gameObject.AddComponent<FollowPath>();
        follow.moveSpeed = (float)enemyInfo.speed;
        follow.StartFollowing(path.pathPoints, true);
    }

    public void RemoveHealth(double amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);            
        }
    }
}