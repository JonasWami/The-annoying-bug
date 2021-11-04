using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timebar : MonoBehaviour
{
    Slider slider;

    private void Start()
    {
        slider = GetComponent<Slider>();

        slider.value = slider.maxValue;
    }

    public void LooseTime(float timelost)
    {
        slider.value -= timelost;
    }
}
