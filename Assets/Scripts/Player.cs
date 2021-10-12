using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }
    public Wallet wallet;
    public int bonusCashAmt = 15;
    public float timeBetweenBonusCash = 3.5f;
    private float nextTimeToAddCash;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            Instance = this;
            nextTimeToAddCash = Time.time + timeBetweenBonusCash;
        }
    }

    private void Start()
    {
        if (Instance.wallet == null)
            Instance.wallet = new Wallet(400);
    }

    private void Update()
    {
        AddCashIfPossible();
    }

    private bool AddCashIfPossible()
    {
        if (Time.time < nextTimeToAddCash)
            return false;

        AddBonusCash();
        nextTimeToAddCash = Time.time + timeBetweenBonusCash;
        return true;
    }

    private void AddBonusCash()
    {
        Instance.wallet.AddCash(bonusCashAmt);
    }
}
