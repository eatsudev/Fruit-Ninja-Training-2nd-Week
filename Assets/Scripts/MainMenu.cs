using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("quitted");
    }
}
