using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetSliderInput : MonoBehaviour
{
    public static Slider slider;
    public float painValue;
    public string painLevel = "2";
    public string getSliderInput()
    {
        painValue = slider.value;
        painLevel = painValue.ToString();
        return painLevel;
    }
}
