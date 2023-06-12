using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool isrunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
        //if player prees w 
        if(!isWalking && forwardPressed)
        {
            // isWalking bool set to true 
            animator.SetBool(isWalkingHash, true);
        }
        //if w not pressed
        if (isWalking && !forwardPressed)
        {
            //isWalknig bool seto to false
            animator.SetBool(isWalkingHash, false);
        }
        // if player is walking and not running and presses left shift
        if(!isrunning && (forwardPressed && runPressed))
        {
            //isRunning set to true
            animator.SetBool(isRunningHash, true);
        }
        //if player stops runnig and stops running or walking
        if(isrunning && (!forwardPressed || !runPressed))
        {
            //isRunning set to false
            animator.SetBool(isRunningHash, false);
        }
    }
}
