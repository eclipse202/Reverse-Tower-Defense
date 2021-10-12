using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    public void OnButtonPress()
    {
        SceneManager.LoadScene("SampleScene");
        Player.Instance.wallet.SetCash(100);
        //LevelControler.GoToSampleScene();
    }

    public void OnButtonPressExit()
    {
        Application.Quit();
    }
}
