using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeminiManager : MonoBehaviour
{
  
    public static bool Art_1_IsPlaying = false;
    public static bool Art_2_IsPlaying = false;
    public static bool Art_3_IsPlaying = false;
    public static bool Art_4_IsPlaying = false;
    public static bool Art_5_IsPlaying = false;
    public static bool Art_6_IsPlaying = false;
    public static bool Art_7_IsPlaying = false;
    public static bool Art_8_IsPlaying = false;
    public static bool Art_9_IsPlaying = false;
    public static bool Art_10_IsPlaying = false;
    public static bool Art_11_IsPlaying = false;
    public static bool Art_12_IsPlaying = false;


    public Animator Art_1_Animator;
    public Animator Art_2_Animator;
    public Animator Art_3_Animator;
    public Animator Art_4_Animator;
    public Animator Art_5_Animator;
    public Animator Art_6_Animator;
    public Animator Art_7_Animator;
    public Animator Art_8_Animator;
    public Animator Art_9_Animator;
    public Animator Art_10_Animator;
    public Animator Art_11_Animator;
    public Animator Art_12_Animator;


    public GameObject Mirror3;


    // Update is called once per frame
    void Update()
    {
        PuzzleItemDetection();
    }
    void PuzzleItemDetection()
    {
        // check if animations where played
        if (this.Art_1_Animator.GetCurrentAnimatorStateInfo(0).IsName("Art1_Trigger"))
        {

            Art_1_IsPlaying = true;
            

        }
        if (this.Art_2_Animator.GetCurrentAnimatorStateInfo(0).IsName("Art2_Trigger"))
        {

            Art_1_IsPlaying = true;
            
        }

        if (this.Art_3_Animator.GetCurrentAnimatorStateInfo(0).IsName("Art3_Trigger"))
        {

            Art_1_IsPlaying = true;
            
        }

        if (this.Art_4_Animator.GetCurrentAnimatorStateInfo(0).IsName("Art4_Trigger"))
        {

            Art_1_IsPlaying = true;
            
        }

        if (this.Art_5_Animator.GetCurrentAnimatorStateInfo(0).IsName("Art5_Trigger"))
        {

            Art_5_IsPlaying = true;
            
        }

        if (this.Art_6_Animator.GetCurrentAnimatorStateInfo(0).IsName("Art6_Trigger"))
        {

            Art_6_IsPlaying = true;
            
        }

        if (this.Art_7_Animator.GetCurrentAnimatorStateInfo(0).IsName("Art7_Trigger"))
        {

            Art_7_IsPlaying = true;
            
        }

        if (this.Art_8_Animator.GetCurrentAnimatorStateInfo(0).IsName("Art8_Trigger"))
        {

            Art_8_IsPlaying = true;
            
        }

        if (this.Art_9_Animator.GetCurrentAnimatorStateInfo(0).IsName("Art9_Trigger"))
        {

            Art_9_IsPlaying = true;
            
        }

        if (this.Art_10_Animator.GetCurrentAnimatorStateInfo(0).IsName("Art10_Trigger"))
        {

            Art_10_IsPlaying = true;
            
        }

        if (this.Art_11_Animator.GetCurrentAnimatorStateInfo(0).IsName("Art11_Trigger"))
        {

            Art_11_IsPlaying = true;
            
        }

        if (this.Art_12_Animator.GetCurrentAnimatorStateInfo(0).IsName("Art12_Trigger"))
        {

            Art_12_IsPlaying = true;
            
        }


        // check if all is true 

        if (Art_1_IsPlaying && Art_2_IsPlaying && Art_3_IsPlaying && Art_4_IsPlaying && Art_5_IsPlaying && Art_6_IsPlaying && Art_7_IsPlaying && Art_8_IsPlaying && Art_9_IsPlaying && Art_10_IsPlaying && Art_11_IsPlaying && Art_12_IsPlaying == true)
        {
            
            Activate();

        }
    }

    // activate Reward
    void Activate()
    {

        Mirror3.SetActive(true);

    }

}
