using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MotionControl : MonoBehaviour
{
    private Animator animator, cameraAnimator;
    public Camera camera; // This will be adjusted

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        cameraAnimator = camera.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            cameraAnimator.SetBool("IsCrh", true);
        }
        else
        {
            cameraAnimator.SetBool("IsCrh", false);
        }

        if (Math.Abs(Input.GetAxis("Vertical")) < 0.2 && Math.Abs(Input.GetAxis("Horizontal")) < 0.2)// Check for input
        {
            animator.SetBool("IsWalking", false);
            // Debug.Log("You are not walking!");
            animator.SetBool("IsRunning", false);
        }
        else
        {
            animator.SetBool("IsWalking", true);
            // Debug.Log("You are walking!");
            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("IsRunning", true);
            }

        }
    }
}
