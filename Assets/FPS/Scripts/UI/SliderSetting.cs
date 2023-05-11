using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSetting : MonoBehaviour
{
    public Slider mainSlider;

    public void Start()
    {
        Debug.Log("here");
        ValueChangeCheck();
        //Adds a listener to the masin slider and invokes a method when the value changes.
        mainSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    // Invoked when the value of the slider changes.
    public void ValueChangeCheck()
    {
        if(mainSlider.name == "size")
        {
            Globals.size = mainSlider.value;
        } else if(mainSlider.name == "speed")
        {
            Globals.speed = mainSlider.value;
        }
        else if (mainSlider.name == "spawnRate")
        {
            Globals.spawnRate = mainSlider.value;
        }
        else if (mainSlider.name == "targetLife")
        {
            Globals.targetLife = mainSlider.value;
        }

}
}
