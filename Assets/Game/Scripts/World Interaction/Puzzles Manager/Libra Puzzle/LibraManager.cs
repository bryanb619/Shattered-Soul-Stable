using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibraManager : MonoBehaviour
{

    // public ScoreManager Script;


    public bool LeftTriggerAnim_IsPlaying = false;
    public bool RightTriggerAnim_IsPlaying = false;

    public Animator libra_left;
    public Animator libra_right;

    public GameObject Mirror;


    [SerializeField]
    private AudioSource Puzzle_Interact;

    // Update is called once per frame
    void Update()
    {
        // check puzzle condition
        LibraUpdate();
    }

    // Puzzle Handler
    private void LibraUpdate()
    {
        // check for Left Trigger
        if (this.libra_left.GetCurrentAnimatorStateInfo(0).IsName("left_trigger"))
        {
            // Make animation true
            LeftTriggerAnim_IsPlaying = true;
            // play interect sound
            Puzzle_Interact.Play();


        }
        // check for Right Trigger
        if (this.libra_right.GetCurrentAnimatorStateInfo(0).IsName("Right_trigger"))
        {
            // Make animation true
            RightTriggerAnim_IsPlaying = true;
            // play interect sound
            Puzzle_Interact.Play();

        }
        // if all true place piece of glass in UI
        if (LeftTriggerAnim_IsPlaying && RightTriggerAnim_IsPlaying == true)
        {
            // call UI 
            PopUI();

        }
    }
    // UI Manager
    void PopUI()
    { 
        // set mirror active
        Mirror.SetActive(true);
    
    }
}
