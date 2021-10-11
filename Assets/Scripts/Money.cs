using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public static int totalMoney = 100;
    public GameObject textDisplay;

    private void Update()
    {
       textDisplay.GetComponent<Text>().text = "Money: " + totalMoney.ToString();
    }

    public static void MoneyDeposit(int x) 
    {
        x = System.Math.Abs(x);
        Debug.Log("added " + x + " to money");
        totalMoney = totalMoney + x;
    }

    public static void MoneyWithdraw(int x)
    {
        x = System.Math.Abs(x);

        if (x - totalMoney < 0)
        {
            Debug.Log("not enough money to subtract");
            return; 
        }

        Debug.Log("subtracted " + x + " to money");
        totalMoney = totalMoney - x;
    }

    public static void MoneySetAmount(int x)
    {
        x = System.Math.Abs(x);
        Debug.Log("set " + x + " to money");
        totalMoney = x;
    }

}
