using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePause= false;
    public GameObject PauseMenuUi;
    
    void Start()
    {
        PauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            if (GamePause)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }
    public void resume()
    {
        PauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;
    }
    void pause()
    {
        PauseMenuUi.SetActive(true);
        //freeze time, spped of the time.
        Time.timeScale = 0f;
        GamePause = true;
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void NetLevel(string LevelName)
    {
        SceneManager.LoadScene(LevelName);
    }

}
