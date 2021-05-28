using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Movement : MonoBehaviour
{

    public float speedH = 2.0f;
    public float mouseSens = 100f;
    
    private float yaw;

    // Update is called once per frame
    void FixedUpdate()
    {
        
        yaw += speedH * Input.GetAxis("Mouse X") * mouseSens;
        // pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(1, yaw, 0.0f);
    }
}
