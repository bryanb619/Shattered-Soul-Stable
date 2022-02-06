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

    private void MirrorsCondition()
    {
        if(MirrorPiece1.activeSelf && MirrorPiece2.activeSelf && MirrorPiece3.activeSelf)
        {
            SceneManager.LoadScene("END_SCREEN");
        }
    }
}
