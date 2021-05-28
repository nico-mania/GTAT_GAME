using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleBeahviour : MonoBehaviour
{
    public float rotationValue = 2;
    public float pushSpeed = 2;
    public float platSpeed = 0.1f;

    private float max,min;

    public float maxPlatR;
    public float minPlatR,minPlatL;

    private bool isRunningPusher = false;

    private void Start()
    {
        max = 8;
        min = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        switch (this.tag)
        {
            case "rotatingBlock":
                transform.Rotate(new Vector3(0, rotationValue, 0));
                break;
            case "pusher":
                transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, Mathf.PingPong(Time.time*10,max-min)+min);
                break;
            case "smasher":
                transform.Rotate(new Vector3(rotationValue, 0, 0));
                break;
            case "stomper":
                transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time*20,40-10)+10, transform.localPosition.z);
                break;
            case "leftplatformer":
                transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time*platSpeed,minPlatR-minPlatL)+minPlatL, transform.localPosition.z);
                break;
            case "rightplatformer":
                transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time*platSpeed,maxPlatR-minPlatR)+minPlatR, transform.localPosition.z);
                break;

        }
    }

    IEnumerator PushSequence()
    {
        isRunningPusher = true;
        while (transform.localPosition.z < 7.5f)
        {
            var transform1 = transform;
            transform1.position += transform1.forward * (Time.deltaTime);
        }
        yield return new WaitForSeconds(2);
        
        while (transform.localPosition.z > 0.2f)
        {
            var transform1 = transform;
            transform1.position -= transform1.forward * (Time.deltaTime);
        }
        yield return new WaitForSeconds(2);
        isRunningPusher = false;
    }
}