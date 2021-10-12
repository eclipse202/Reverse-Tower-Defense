using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }
    public Wallet wallet;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            Instance = this;
        }
    }

    private void Start()
    {
        if (wallet == null)
            wallet = new Wallet(100);
    }
}
