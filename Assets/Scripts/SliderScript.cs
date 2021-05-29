using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    private Slider slider;

    private void Start()
    {
        slider = this.GetComponent<Slider>();
        slider.value = PlayerPrefs.GetFloat("mouseSens");
    }

    public void MouseSensChange(float value)
    {
        PlayerPrefs.SetFloat("mouseSens", value);
    }
}
