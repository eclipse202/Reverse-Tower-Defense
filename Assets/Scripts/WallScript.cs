using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public EnemyInfo enemyInformation;
    public NextLevelInfo nextLevelInfo;

    public int health;

    private bool i = true;

    private int GetAttackDamage()
    {
        return enemyInformation.attackDamage;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            health =- GetAttackDamage();
            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
        if (i == true)
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
                newLevelControler.LevelChanger(nextLevelInfo.nextLevel.ToString());
                Debug.Log("after space pressed");
            }

        }
    }
           
        
        
    
       
    
      

}

