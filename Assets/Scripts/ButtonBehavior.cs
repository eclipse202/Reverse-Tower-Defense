using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    public void OnButtonPress()
    {
        LevelControler.GoToSampleScene();
    }
    public void OnButtonPressTutorial()
    {
        LevelControler.GoToTutorialPage();
    }
    public void OnButtonPressExit()
    {
        Application.Quit();
    }
}
