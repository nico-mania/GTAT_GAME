using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    private bool canJump = false;

    [SerializeField]
    private Transform target;

    private float speed = 0.5f;
    private float angle;

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        angle += moveHorizontal * 0.05f;

        // Refers to the direction that the player is looking
        Vector3 targetDirection = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle));

        target.transform.position +=  moveVertical * speed * target.transform.forward;
        target.transform.rotation = Quaternion.LookRotation(targetDirection);
    }


}
