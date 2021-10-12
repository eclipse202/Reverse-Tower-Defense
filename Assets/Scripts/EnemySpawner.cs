using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public KeyCode keyToTriggerSpawn;
    public GameObject enemyPrefab;
    public PathInfo pathPoints;

    void Update()
    {
        if (Input.GetKeyDown(keyToTriggerSpawn))
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        var enemyGameObject = Instantiate(enemyPrefab, new Vector3(-9, 0, 0), Quaternion.identity);
        var enemy = enemyGameObject.GetComponent<Enemy>();

        var enemyCost = enemy.enemyInfo.moneyCost;
        var wallet = Player.Instance.wallet;
        if (!wallet.CanAfford(enemyCost))
        {
            GameObject.Destroy(enemyGameObject);
            return;
        }

        wallet.RemoveCash(enemyCost);
        enemy.FollowPath(pathPoints);
    }
}
