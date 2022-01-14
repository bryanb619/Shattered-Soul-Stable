using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleExit : MonoBehaviour
{
    public void ExitButton()
    {
        SceneManager.LoadScene("Game");
    }

}
