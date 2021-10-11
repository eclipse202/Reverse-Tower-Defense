using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelControler : MonoBehaviour
{
    private void Start()
    {
        transform.position = transform.forward * 1;
    }

    private void Awake()
    {
        
    }

    public void WinScreenAppear()
    {
        transform.position = transform.forward * -10;
        Debug.Log("hit space to continue");
    }

    public void LevelChanger()
    {
        string level = NextLevelName.nextLevel;

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


}
