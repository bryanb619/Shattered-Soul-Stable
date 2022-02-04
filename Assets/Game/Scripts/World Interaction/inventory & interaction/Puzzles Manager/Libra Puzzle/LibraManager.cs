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

    public AudioSource Puzzle_Interact;

    // Update is called once per frame
    void Update()
    {

        LibraUpdate();
    }


    private void LibraUpdate()
    {
        if (this.libra_left.GetCurrentAnimatorStateInfo(0).IsName("left_trigger"))
        {

            LeftTriggerAnim_IsPlaying = true;
            Puzzle_Interact.Play();


        }
        if (this.libra_right.GetCurrentAnimatorStateInfo(0).IsName("Right_trigger"))
        {

            RightTriggerAnim_IsPlaying = true;
            Puzzle_Interact.Play();

        }

        if (LeftTriggerAnim_IsPlaying && RightTriggerAnim_IsPlaying == true)
        {
            PopUI();

        }

    }

    void PopUI()
    {
        Mirror.SetActive(true);
    }

}
