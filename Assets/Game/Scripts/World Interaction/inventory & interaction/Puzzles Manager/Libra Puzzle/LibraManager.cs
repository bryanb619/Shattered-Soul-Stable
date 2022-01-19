using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LibraManager : MonoBehaviour
{

    // public ScoreManager Script;


    public static bool LeftTriggerAnim_IsPlaying = false;
    public static bool RightTriggerAnim_IsPlaying = false;

    public Animator libra_left;
    public Animator libra_right;

    public GameObject Mirror;


    

    // Start is called before the first frame update
    void Start()
    {
    
    }


    // Update is called once per frame
    void Update()
    {
        if (this.libra_left.GetCurrentAnimatorStateInfo(0).IsName("left_trigger"))
        { 

            LeftTriggerAnim_IsPlaying = true;
           

        }
        if (this.libra_right.GetCurrentAnimatorStateInfo(0).IsName("Right_trigger"))
        {
           
            RightTriggerAnim_IsPlaying = true;
            
        }

        if (LeftTriggerAnim_IsPlaying && RightTriggerAnim_IsPlaying == true)
        {
            BothActive();

        }
        

    }

    void BothActive()
    {

        //Debug.Log("You Won");
        PopUI();
        
    }
    void PopUI()
    {
        Mirror.SetActive(true);
    }

}
