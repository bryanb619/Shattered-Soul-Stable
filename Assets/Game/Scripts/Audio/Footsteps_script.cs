using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps_script : MonoBehaviour
{

    public AudioSource FootstepsSource;

    


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) //&& characterController.isGrounded)
        {
            FootstepsSource.Play();
        }
        else
            FootstepsSource.Stop();

    }
}
