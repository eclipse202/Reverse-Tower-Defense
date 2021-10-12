using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Tower : MonoBehaviour
{
    public TowerInfo towerInformation;
    public GameObject projectilePrefab;
    private List<Enemy> enemiesToAttack = new List<Enemy>();
    private float nextShootTime;

    private void Start()
    {
        GetComponent<CircleCollider2D>().radius = (float)towerInformation.attackRange;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemiesToAttack.Count == 0 || enemiesToAttack.First()?.gameObject == null)
            return;

        RotateToTarget(enemiesToAttack.First().gameObject);
        ShootIfPossible();
    }

    private void RotateToTarget(GameObject target)
    {
        Vector3 vectorToTarget = target.transform.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        angle = angle - 90;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * (float)towerInformation.attackSpeed);
    }
    
    public void Shoot()
    {
        var projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
        projectile.GetComponent<Projectile>().Init(towerInformation);
    }

    public bool ShootIfPossible()
    {
        if (Time.time < nextShootTime)
            return false;
        
        Shoot();
        nextShootTime = Time.time + (float)(1 / towerInformation.attackSpeed);
        return true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemiesToAttack.Add(collision.gameObject.GetComponent<Enemy>());
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        enemiesToAttack.Remove(collision.gameObject.GetComponent<Enemy>());
    }
}
