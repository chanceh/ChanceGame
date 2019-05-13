using System;
using UnityEngine;
using UnityEngine.UI;

public class RotationSlider : MonoBehaviour
{
    public Slider[] sliders;

    public void Start()
    {
        for (int i = 0; i < sliders.Length+ -1; i++)
        {
            Slider sldrs = sliders[i].GetComponent<Slider>();
            sldrs.onValueChanged.AddListener(delegate { ValueChangeCheck(i); });
        }
    }

    public void ValueChangeCheck(int sliderIndex)
    {
        Debug.Log("Slider #" + sliderIndex, sliders[sliderIndex]);
    }
}
