using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public TowerInfo towerInformation;

    public GameObject projectilePrefab;

    private void Start()
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
        Instantiate(projectilePrefab, transform.position, transform.rotation);
    }

}
