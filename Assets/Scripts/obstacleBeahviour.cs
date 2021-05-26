using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleBeahviour : MonoBehaviour
{
    public float rotationValue = 2;
    public float pushSpeed = 2;

    private float max,min;

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