using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour
{
    static int cost = EnemySpawner.CostOfEnemy();

    public GameObject textDisplay;

    private void Update()
    {
        textDisplay.GetComponent<Text>().text = "Cost: " + CostToString(cost);
    }

    void Awake()
    {
        EnemySpawner enemySpawner = GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>();
    }

    void Start()
    {
        
    }
    public static string CostToString(int x)
    {
        if (cost != null)
        {
            string stringOfMoney = cost.ToString();
            return stringOfMoney;
        }
        return "something doesnt have a value";
    }
}
