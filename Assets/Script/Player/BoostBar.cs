﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostBar : MonoBehaviour
{

    public Slider slider;
    
    public void SetMaxBoost(int boost)
    {
        slider.maxValue = boost;
        slider.value = boost;
    } 

    public void SetBoost(int boost)
    {
        slider.value = boost;

    }
}
