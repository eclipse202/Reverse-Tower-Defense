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

    private void Awake()
    {
        
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
                break;
            case "SampleScene":
                SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
                break;

            case "Level2":
                SceneManager.LoadScene("Level2", LoadSceneMode.Single);
                break;

            case "Level3":
                SceneManager.LoadScene("Level3", LoadSceneMode.Single);
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
    }

    public static void GoToSampleScene()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public static void GoToTutorialPage()
    {
        SceneManager.LoadScene("TutorialPage", LoadSceneMode.Single);
    }


}
