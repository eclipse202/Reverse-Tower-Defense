using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet
{
    public int Cash { get; private set; }

    public Wallet()
    {
        SetCash(0);
    }

    public Wallet(int startingCash)
    {
        SetCash(startingCash);
    }

    public bool CanAfford(int amount)
    {
        return Cash >= amount;
    }

    public void AddCash(int amountToAdd)
    {
        amountToAdd = System.Math.Abs(amountToAdd);
        SetCash(Cash + amountToAdd);
    }

    public void RemoveCash(int amountToRemove)
    {
        amountToRemove = System.Math.Abs(amountToRemove);
        if (Cash - amountToRemove < 0)
        {
            Debug.Log("Not enough money to remove");
            return;
        }

        SetCash(Cash - amountToRemove);
    }

    public void SetCash(int amountToSet)
    {
        amountToSet = System.Math.Abs(amountToSet);
        Cash = amountToSet;
        PlayerHUD.UpdateCashText(Cash);
    }
}
