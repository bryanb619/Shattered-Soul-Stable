using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{   
    // Buttons
    public void PlayButton ()
    {   
        //Load Game scene (start game)
        SceneManager.LoadScene("Game");
    }
    public void QuitButton ()
    {   
        // Quit game
        Application.Quit();
        // 
        Debug.Log("Game whas Quitted");
    }
        
    
}
