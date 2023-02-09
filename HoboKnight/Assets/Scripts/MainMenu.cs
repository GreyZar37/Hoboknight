using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayBtn()
    {
        SceneManager.LoadScene("SCENE_NAME");
    }
    public void QuitBtn()
    {
        Application.Quit();
    }
    public void OptionsBtn()
    {
        SceneManager.LoadScene("SCENE_NAME");
    }
}
