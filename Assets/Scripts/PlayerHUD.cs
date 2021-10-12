using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour
{
    public static PlayerHUD Instance { get; private set; }
    public Text cashText;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            Instance = this;
        }
    }
    
    public static void UpdateCashText(int amount)
    {
        Instance.cashText.text = "Cash: " + amount.ToString();
    }
}
