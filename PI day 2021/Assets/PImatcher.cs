using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PImatcher : MonoBehaviour
{
    public decimal realpi = 3.14159265358979323m;
 
    public Slider slider;
    public Text text;
    decimal pi(int depth)
    {
        return System.Math.Round(realpi, depth);
    }
    private void Start()
    {

        int count = BitConverter.GetBytes(decimal.GetBits(realpi)[3])[2];
        slider.maxValue = count;
        slider.onValueChanged.AddListener(delegate { set(); });
    }
    void set()
    {
        string texter = pi((int)slider.value).ToString();
        text.text = "PI="+texter;
    }
}
