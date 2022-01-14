using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GPanelTrigger : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        // number 2 represents Gemini Scene
        SceneManager.LoadScene(1);
    }
}
