using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibraManager : MonoBehaviour
{
    public bool LeftTriggerAnim_IsPlaying = false;
    public bool RightTriggerAnim_IsPlaying = false;

    public Animator libra_left;
    public Animator libra_right;

    public Animation left_trigger;
    public Animation right_trigger;

    

    // Start is called before the first frame update
    void Start()
    {
        libra_left = GetComponent<Animator>();

        libra_right = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if (this.libra_left.GetCurrentAnimatorStateInfo(0).IsName("left_trigger"))
        { 

            LeftTriggerAnim_IsPlaying = true;
            Debug.Log("left active");

        }
        if (this.libra_right.GetCurrentAnimatorStateInfo(0).IsName("Right_trigger"))
        {
           
            RightTriggerAnim_IsPlaying = true;
            Debug.Log("right active");
        }

        if (LeftTriggerAnim_IsPlaying && RightTriggerAnim_IsPlaying == true)
        {
            BothActive();
        }

    }

    public void BothActive()
    {
        Debug.Log("You Won");

    }

}
