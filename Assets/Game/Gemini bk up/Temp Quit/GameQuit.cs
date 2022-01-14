using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameQuit : MonoBehaviour
{
    public void ExitGame ()
    {
        Application.Quit();
        Debug.Log("Game is terminated");
    }

}
