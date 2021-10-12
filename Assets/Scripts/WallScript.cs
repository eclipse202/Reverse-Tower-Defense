using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public string nextSceneName;
    public int health;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.ToLower() != "enemy")
            return;

        var enemy = collision.gameObject.GetComponent<Enemy>();
        OnTakeDamage(enemy.enemyInfo.attackDamage);
        Destroy(collision.gameObject);
    }

    private void OnTakeDamage(int amount)
    {
        health -= amount;
        if (health > 0)
            return;

        OnKill();
    }

    private void OnKill()
    {
        LevelControler newLevelControler = GameObject.Find("WinSquare").GetComponent<LevelControler>();
        newLevelControler.WinScreenAppear();
        newLevelControler.LevelChanger(nextSceneName);
    }

    void Update()
    {
        /*if (i == true)
        {
            if (health <= 0)
            {
                LevelControler newLevelControler = GameObject.Find("WinSquare").GetComponent<LevelControler>();
                newLevelControler.WinScreenAppear();

                i = false;
            }
        }

        if (i == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                LevelControler newLevelControler = GameObject.Find("WinSquare").GetComponent<LevelControler>();
                Debug.Log("space pressed");
                newLevelControler.LevelChanger(nextLevelInfo.nextLevel);
                Debug.Log("after space pressed");
            }
        }*/
    }
}