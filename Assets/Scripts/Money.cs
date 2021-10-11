using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public static int totalMoney = 0;
    public GameObject textDisplay;

    private void Update()
    {
       textDisplay.GetComponent<Text>().text = "Money: " + MoneyToString(totalMoney);
    }

    public static string MoneyToString(int x)
    {
        if (totalMoney != null)
        {
            string stringOfMoney = totalMoney.ToString();
            return stringOfMoney;
        }
        return "something doesnt have a value";
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
        }

        Debug.Log("subtracted " + x + " to money");
        totalMoney = totalMoney + x;
    }

    public static void MoneySetAmount(int x)
    {
        x = System.Math.Abs(x);
        Debug.Log("set " + x + " to money");
        totalMoney = totalMoney + x;
    }

}
