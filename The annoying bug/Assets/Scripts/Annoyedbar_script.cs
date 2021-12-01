using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Annoyedbar_script : MonoBehaviour
{
    public int Winscreen;
    Slider slider;

    private void Start()
    {
        slider = GetComponent<Slider>();

        slider.value = slider.minValue;
    }

    public void Gain(float Gained)
    {
        slider.value += Gained;
    }
    private void Update()
    {
        if (slider.value >= 100)
        {
            SceneManager.LoadScene(Winscreen);
        }
    }
}
