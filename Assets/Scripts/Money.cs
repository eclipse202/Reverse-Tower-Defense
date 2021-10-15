using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public static int totalMoney = 100;
    public GameObject textDisplay;
    public static Text textComponent;


    private void Start()
    {
        textComponent = textDisplay.GetComponent<Text>();
    }

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

    public static void DepsoitMoney2(int amount)
    {
        if (amount <= 0) 
        {
            Debug.LogError("tried to deposited a negative amount");
            return;
        }

        totalMoney += amount;
        Debug.Log("added " + amount + " to money");
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
    public static void WithdrawMoney2(int amount)
    {
        if (totalMoney - amount < 0)
        {
            Debug.LogError("not enough money to subtract");
            return;
        }

        totalMoney -= amount;
        Debug.Log("subtracted " + amount + " to money");
    }

    public static void UpdateCashText()
    {
        textComponent.text = "Money: " + totalMoney.ToString();
    }


}
