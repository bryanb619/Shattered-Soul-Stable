using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndMenu : MonoBehaviour
{

    // buttons
    public void RestartButton()
    {
        
        // use resume method
        SceneManager.LoadScene("Game");

    }

    public void MainMenuButton()
    {
        
        SceneManager.LoadScene("Main_Menu");
        Debug.Log("Menu Loaded");

    }
}
