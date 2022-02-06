using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public GameObject MirrorPiece1;
    public GameObject MirrorPiece2;
    public GameObject MirrorPiece3;

    // Update is called once per frame
    void Update()
    {
        MirrorsCondition();
    }

    // detect game mirrors 
    private void MirrorsCondition()
    {
        // if all active run code and load next scene
        if(MirrorPiece1.activeSelf && MirrorPiece2.activeSelf && MirrorPiece3.activeSelf)
        {
            // cursor new settings
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            // set time to real time ( unpause)
            Time.timeScale = 1f;

            // Load end scene
            SceneManager.LoadScene("END_SCREEN");

        }
    }
}
