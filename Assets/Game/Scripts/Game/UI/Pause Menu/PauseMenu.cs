using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{

    // Variables 
    // game pased bool 
    public static bool Paused = false;

    // Pause menu UI OBJECT
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }

    }

    // method Resume
    void Resume()
    {

        pauseMenu.SetActive(false);

        Time.timeScale = 1f;

        Paused = false;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }
    // method pause
    void Pause()
    {

        pauseMenu.SetActive(true);

        Time.timeScale = 0f;

        Paused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    // buttons
    public void Resumeutton()
    {
        // use resume method
        Resume();

    }

    public void MenuButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main_Menu");
        Debug.Log("Scene Loaded");

    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game is terminated");
    }
}
