using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public CharacterController controller;
    public float moveSpeed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    Vector3 velocity;
    bool isGrounded = true;

    // Update is called once per frame
    void Update()
    {
        if(controller.isGrounded){
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

        //Movement
        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        controller.Move(move * (moveSpeed * Time.deltaTime));

        //Jumping
        if(Input.GetButtonDown("Jump") && isGrounded){
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            isGrounded = false;
        }

        //Gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
