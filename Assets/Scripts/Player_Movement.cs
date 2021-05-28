using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
<<<<<<< Updated upstream

=======
    public Animation animation;
>>>>>>> Stashed changes
    public CharacterController controller;
    public float moveSpeed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    Vector3 velocity;
    bool isGrounded = true;

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        if(controller.isGrounded){
=======
        if (controller.isGrounded)
        {
>>>>>>> Stashed changes
            velocity.y = -2f;
            isGrounded = true;
        }

        if (!controller.isGrounded)
        {
            isGrounded = false;
        }

        //Keyboard Input
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
<<<<<<< Updated upstream
=======
        
>>>>>>> Stashed changes

        //Movement
        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        controller.Move(move * (moveSpeed * Time.deltaTime));
<<<<<<< Updated upstream

        //Jumping
        if(Input.GetButtonDown("Jump") && isGrounded){
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            isGrounded = false;
        }

=======
/****/
        if (Input.GetAxis("Vertical") > 0.05f){
            animation.Play("Running");

        }else{
            animation.Play("Idle");
        }

        //Jumping
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            isGrounded = false;   
        }

/****/

>>>>>>> Stashed changes
        //Gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
<<<<<<< Updated upstream
}
=======
}
>>>>>>> Stashed changes
