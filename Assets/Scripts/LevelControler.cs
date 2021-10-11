using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelControler : MonoBehaviour
{

    public Renderer rend;
    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }

    public void WinScreenAppear()
    {
        rend.enabled = true;
        Debug.Log("winscreeappears");
    }

    public void LevelChanger(string level)
    {
        switch (level)
        {
            case "MainMenu":
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
                Money.MoneySetAmount(0);
                break;
            case "SampleScene":
                SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
                Money.MoneySetAmount(250);
                break;

            case "Level2":
                SceneManager.LoadScene("Level2", LoadSceneMode.Single);
                Money.MoneySetAmount(300);
                break;

            case "Level3":
                SceneManager.LoadScene("Level3", LoadSceneMode.Single);
                Money.MoneySetAmount(400);
                break;

            default:
                Debug.Log("error, levelchanger switch");
                break;
      

        }

        return;
    }

    public static void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        Money.MoneySetAmount(0);
    }

    public static void GoToSampleScene()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        Money.MoneySetAmount(250);
    }

    public static void GoToTutorialPage()
    {
        SceneManager.LoadScene("TutorialPage", LoadSceneMode.Single);
        Money.MoneySetAmount(0);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;
            SceneManager.LoadScene(sceneName);
        }
    }
}
