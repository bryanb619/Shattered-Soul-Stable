using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AquariusPuzzleManager : MonoBehaviour
{

    // public ScoreManager Script;


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

    public AudioSource Puzzle_Interact;



    // public Animator Greek_Animator;

    //private Animation animSkull;
    //public Animation right_trigger;
    public GameObject Mirror2;

    void Start()
    {
        //animSkull = gameObject.GetComponent<Animation>();

    }


        // Update is called once per frame
    void Update()
    {
        PuzzleItemDetection();


    }
    void PuzzleItemDetection()
    {

        if (this.Skull_Animator.GetCurrentAnimatorStateInfo(0).IsName("Skull_Trigger"))
        {

            SkullTriggerAnim_IsPlaying = true;
            Debug.Log("skull active");

            Skull_Animator.SetTrigger("Object_Insert");



            //animSkull.Play("animalSkull");

        }
        if (this.Rope_Animator.GetCurrentAnimatorStateInfo(0).IsName("Rope_Trigger"))
        {

            Puzzle_Interact.Play();
            RopeTriggerAnim_IsPlaying = true;

            
        }

        if (this.Greek_Animator.GetCurrentAnimatorStateInfo(0).IsName("Greek_Staue_Trigger"))
        {

            GreekStatueTriggerAnim_IsPlaying = true;
            Puzzle_Interact.Play();
        }

        if (this.Cauldron_Animator.GetCurrentAnimatorStateInfo(0).IsName("Cauldron_Staue_Trigger"))
        {

            CauldronStatueTriggerAnim_IsPlaying = true;
            Puzzle_Interact.Play();

        }

        if (this.Vase_Animator.GetCurrentAnimatorStateInfo(0).IsName("Vase_Trigger"))
        {

            VaseStatueTriggerAnim_IsPlaying = true;
            Puzzle_Interact.Play();

        }

        if (this.Bottle_Animator.GetCurrentAnimatorStateInfo(0).IsName("Bottle_Trigger"))
        {

            BottleTriggerAnim_IsPlaying = true;
            Puzzle_Interact.Play();

        }






        // check if all is true 

        if (SkullTriggerAnim_IsPlaying && RopeTriggerAnim_IsPlaying && GreekStatueTriggerAnim_IsPlaying && CauldronStatueTriggerAnim_IsPlaying && VaseStatueTriggerAnim_IsPlaying && BottleTriggerAnim_IsPlaying == true)
        {
            
            Activate();

        }
    }

    void Activate()
    {

        
        PopUI();

    }
    void PopUI()
    {
        Mirror2.SetActive(true);
    }

}

