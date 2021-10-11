using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyInfo enemyInformation;
    public KeyCode keyToTriggerSpawn;
    public GameObject enemyPrefab;
    public int costOfEnemy;

    private void Start()
    {

    }

   
    void Update()
    {
        if (Input.GetKeyDown(keyToTriggerSpawn))
        {
            SpawnEnemy();
        }

        void SpawnEnemy()
        {
            Instantiate(enemyPrefab, new Vector3(-9, 0, 0), Quaternion.identity);
            Money.MoneyWithdraw(costOfEnemy);
        }
    }

    public static void CostOfEnemy()
    {

    }
    
   
}
