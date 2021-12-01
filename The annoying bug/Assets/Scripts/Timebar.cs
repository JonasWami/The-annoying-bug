using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timebar : MonoBehaviour
{
    public int blackscreen;
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
    private void Update()
    {
        if(slider.value <= 0)
        {
            Debug.Log("dead");
            SceneManager.LoadScene(blackscreen);
        }
    }
}
