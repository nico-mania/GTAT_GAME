using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Movement : MonoBehaviour
{

    public float speedH = 2.0f;
    
    private float yaw ;

    // Update is called once per frame
    void Update()
    {
        
        yaw += speedH * Input.GetAxis("Mouse X");
        // pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.localRotation = Quaternion.Euler(1, yaw, 0.0f);

    }
}
