using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teste : MonoBehaviour
{
    public Slider slider;
    public static float FontSize = 40;


     void Start()
    {
        slider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
    }

    public void ValueChangeCheck()
    {
        FontSize = slider.value;
        Debug.Log(slider.value);

    }
}
