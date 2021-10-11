using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelControler : MonoBehaviour
{
    private WallScript wallScriptInfo;

    public static string level;

    private void Awake()
    {
        wallScriptInfo = GetComponent<WallScript>();
    }

    public void LevelChanger()
    {
        Debug.Log("button click");
        level = wallScriptInfo.nextLevel;

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
    }
}
