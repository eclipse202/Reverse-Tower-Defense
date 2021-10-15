using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelControler : MonoBehaviour
{
    public Renderer rend;
    private string nextLevel;
    private int nextStartingCash;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        if (rend.enabled && Input.GetKeyDown(KeyCode.Space))
            SwitchLevel(nextLevel, nextStartingCash);
    }

    public void SwitchLevel(string sceneName, int startingCash)
    {
        rend.enabled = false;
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        Player.Instance.wallet.SetCash(startingCash);
    }

    public void WinScreenAppear()
    {
        rend.enabled = true;
        Debug.Log("Win Screen Appeared");
    }

    public void LevelChanger(string level)
    {
        nextLevel = level;
        switch (level)
        {
            case "MainMenu":
                nextStartingCash = 0;
                break;
            case "SampleScene":
                nextStartingCash = 250;
                break;

            case "Level2":
                nextStartingCash = 300;
                break;

            case "Level3":
                nextStartingCash = 400;
                break;

            default:
                Debug.Log("error, levelchanger switch");
                break;
        }

        return;
    }
}
