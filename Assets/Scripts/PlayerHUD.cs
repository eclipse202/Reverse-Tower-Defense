using UnityEngine;

public class PlayerHUD : MonoBehaviour
{
    public PlayerHUD Instance { get; private set; }

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        
    }
}
