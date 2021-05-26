using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleBeahviour : MonoBehaviour
{
    public float rotationValue = 2;

    // Update is called once per frame
    void FixedUpdate()
    {
        switch (this.tag)
        {
            case "rotatingBlock":
                transform.Rotate(new Vector3(0, rotationValue, 0));
                break;
        }
    }
}