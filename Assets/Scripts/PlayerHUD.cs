using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour
{
    //static int cost = EnemySpawner.CostOfEnemy();
    static int cost = 0;

    public Text textDisplay;

    void Start()
    {
        textDisplay.GetComponent<Text>().text = "Cost: " + cost.ToString();
    }

    private void Update()
    {
        
    }
}
