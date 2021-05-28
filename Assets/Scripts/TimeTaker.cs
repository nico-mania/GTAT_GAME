using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTaker : MonoBehaviour
{
    public static float mapTime = 0;
    private bool timerStart = false;
    private void OnTriggerExit(Collider other)
    {
        switch (this.tag)
        {
            case "Start":
                RestartTimer();
                break;
            case "Finish":
                StopTimer();
                break;
        }
    }

    private void Update()
    {
        if (timerStart)
        {
            // mapTime is in seconds
            // deltaTime simulates 100 frames per second
            // meaning mapTime is increment 100 times per second by 0.01
            mapTime += Time.deltaTime;
        }
    }

    private void RestartTimer()
    {
        mapTime = 0;
        timerStart = true;
    }

    private void StopTimer()
    {
        timerStart = false;
        // ToString("F1") cuts anything after the 1st decimal value off
        Debug.Log(mapTime.ToString("F1"));
    }
}
