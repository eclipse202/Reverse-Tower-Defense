using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public TowerInfo towerInformation;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * towerInformation.projectileSpeed;
    }
  
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }



}
