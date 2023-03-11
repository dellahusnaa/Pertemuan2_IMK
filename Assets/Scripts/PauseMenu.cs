using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{

     public GameObject PauseMenuPanel;

    public void Pause()
    {
        PauseMenuPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        PauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Restart()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("Scene3");
    }

    public void Restart2()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("Scene1");
    }

    public void Restart3()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("Scene2");
    }
}
