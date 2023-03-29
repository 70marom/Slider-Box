using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderVOL : MonoBehaviour
{
    public Slider slider;

    public void Start()
    {
        slider.value = PlayerPrefs.GetFloat("value", 1);
    }
    public void Update()
    {
        PlayerPrefs.SetFloat("value", slider.value);
    }


}
