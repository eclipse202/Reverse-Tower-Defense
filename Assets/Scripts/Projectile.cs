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
        
    }

    public void Init(TowerInfo info)
    {
        towerInformation = info;
        rb.velocity = transform.up * towerInformation.projectileSpeed;
        Destroy(this.gameObject, 2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.ToLower() != "enemy")
            return;

        var enemy = collision.gameObject.GetComponent<Enemy>();
        enemy.RemoveHealth(towerInformation.attackDamage);
        Destroy(this.gameObject);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
