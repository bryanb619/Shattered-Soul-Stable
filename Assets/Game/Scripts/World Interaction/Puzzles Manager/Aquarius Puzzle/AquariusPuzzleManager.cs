using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AquariusPuzzleManager : MonoBehaviour
{

    public static bool SkullTriggerAnim_IsPlaying = false;
    public static bool RopeTriggerAnim_IsPlaying = false;
    public static bool GreekStatueTriggerAnim_IsPlaying = false;
    public static bool CauldronStatueTriggerAnim_IsPlaying = false;
    public static bool VaseStatueTriggerAnim_IsPlaying = false;
    public static bool BottleTriggerAnim_IsPlaying = false;

    public Animator Skull_Animator;
    public Animator Rope_Animator;
    public Animator Greek_Animator;
    public Animator Cauldron_Animator;
    public Animator Vase_Animator;
    public Animator Bottle_Animator;

    //
    [SerializeField]
    private AudioSource Puzzle_Interact;

    // Puzzle Reward
    public GameObject Mirror2;


    // Update is called once per frame
    void Update()
    {
        // Check puzzle condition
        PuzzleItemDetection();

    }
    void PuzzleItemDetection()
    {
        // check for Skull Trigger
        if (this.Skull_Animator.GetCurrentAnimatorStateInfo(0).IsName("Skull_Trigger"))
        {

            SkullTriggerAnim_IsPlaying = true;
            Puzzle_Interact.Play();

        }
        // check for Rope Trigger
        if (this.Rope_Animator.GetCurrentAnimatorStateInfo(0).IsName("Rope_Trigger"))
        {
            // play interect sound
            Puzzle_Interact.Play();
            RopeTriggerAnim_IsPlaying = true;

            
        }
        // check for Statue Trigger
        if (this.Greek_Animator.GetCurrentAnimatorStateInfo(0).IsName("Greek_Staue_Trigger"))
        {

            GreekStatueTriggerAnim_IsPlaying = true;
            // play interect sound
            Puzzle_Interact.Play();
        }
        // check for Cauldron Trigger
        if (this.Cauldron_Animator.GetCurrentAnimatorStateInfo(0).IsName("Cauldron_Staue_Trigger"))
        {

            CauldronStatueTriggerAnim_IsPlaying = true;
            // play interect sound
            Puzzle_Interact.Play();

        }
        // check for vase Trigger
        if (this.Vase_Animator.GetCurrentAnimatorStateInfo(0).IsName("Vase_Trigger"))
        {

            VaseStatueTriggerAnim_IsPlaying = true;
            // play interect sound
            Puzzle_Interact.Play();

        }
        // check for Bottle Trigger
        if (this.Bottle_Animator.GetCurrentAnimatorStateInfo(0).IsName("Bottle_Trigger"))
        {

            BottleTriggerAnim_IsPlaying = true;
            // play interect sound
            Puzzle_Interact.Play();

        }

        // check if all is true 
        if (SkullTriggerAnim_IsPlaying && RopeTriggerAnim_IsPlaying && GreekStatueTriggerAnim_IsPlaying && CauldronStatueTriggerAnim_IsPlaying && VaseStatueTriggerAnim_IsPlaying && BottleTriggerAnim_IsPlaying == true)
        {
            
            PopUI();

        }
    }
    void PopUI()
    {
        Mirror2.SetActive(true);

        // END OF CODE
    }

}

