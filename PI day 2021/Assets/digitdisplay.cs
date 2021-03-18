using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class digitdisplay : MonoBehaviour
{
    public Text text;
    public Slider slider;
    private void Start()
    {
        slider.onValueChanged.AddListener(delegate { set(); });
    }
    void set()
    {
        string val = slider.value.ToString();
        text.text = val;
    }
}
