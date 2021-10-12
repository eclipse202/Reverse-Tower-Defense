using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Projectile : MonoBehaviour
{
    public TowerInfo towerInformation;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * towerInformation.projectileSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.ToLower() != "enemy")
            return;

        var enemy = collision.gameObject.GetComponent<Enemy>();
        enemy.RemoveHealth(towerInformation.attackDamage);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
