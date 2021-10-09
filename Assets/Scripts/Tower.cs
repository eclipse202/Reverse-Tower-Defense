using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public TowerInfo towerInformation;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        { 
            Shoot();
        }
    }
    
    public void Shoot()
    {
        GameObject projectile = GameObject.Instantiate(projectilePrefab, transform);
        //projectile.transform.Translate((projectile.transform.forward * towerInformation.projectileSpeed * Time.deltaTime));
        projectile.transform.position = new Vector3(-10, -10, -1);
    }

}
