using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    /// <summary>
    /// PlayeMovement handles the movement of the player by specifying player speed, reading user Input,
    /// and calling CharacterController2D to move the Player Object  
    /// </summary>
    
    [SerializeField] private float runSpeed;
    float horizontalMove = 0f;
    bool jump = false;
    public CharacterController2D controller;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("moveX",horizontalMove);

        if (horizontalMove != 0)
        {
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        
        animator.SetBool("jumping", jump);
    }

    // FixedUpdate is called multiple times per x amount of frames
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }
}
