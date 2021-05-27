using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Movement : MonoBehaviour
{

    public float speedH = 2.0f;
<<<<<<< Updated upstream
    
    private float yaw ;
=======
    public float mouseSens = 100f;
    
    private float yaw;
>>>>>>> Stashed changes

    // Update is called once per frame
    void Update()
    {
        
<<<<<<< Updated upstream
        yaw += speedH * Input.GetAxis("Mouse X");
        // pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.localRotation = Quaternion.Euler(1, yaw, 0.0f);

=======
        yaw += speedH * Input.GetAxis("Mouse X") * mouseSens;
        // pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(1, yaw, 0.0f);
>>>>>>> Stashed changes
    }
}
