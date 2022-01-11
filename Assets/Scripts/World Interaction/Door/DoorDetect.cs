using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDetect : MonoBehaviour
{
    public Transform _cameraTransform;
    // Unity header
    [Header("MaxDistance you can open or close door.")]
    // open door max distance
    public float OpenDoorMax = 5;
    // original door condition
    private bool opened = false;
    // animator
    private Animator anim;
 
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            //attempt to open door 
            Pressed();

        }
    }

    private void Pressed()
    {
        //This will name the Raycasthit and came information of which object the raycast hit.
        RaycastHit doorhit;

        if (Physics.Raycast(_cameraTransform.transform.position, _cameraTransform.transform.forward, out doorhit, OpenDoorMax))
        {

            // checks if raycast hit door
            if (doorhit.transform.tag == "Door")
            {

                // Conect to animator
                anim = doorhit.transform.GetComponentInParent<Animator>();

                //This will set the bool the opposite of what it is.
                opened = !opened;

                //This line will set the bool true so it will play the animation.
                anim.SetBool("Opened", !opened);
            }


        }
    }
}
