using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// scene manager 
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{   // evento para Play button, isto carrega a cena 1 (Game)
    public void PlayButton ()
    {   
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitButton ()
    {   
        Application.Quit();
        // Para saber se funciona, remover este código em versão futura
        Debug.Log("Game whas Quitted");
    }
        
    
}
