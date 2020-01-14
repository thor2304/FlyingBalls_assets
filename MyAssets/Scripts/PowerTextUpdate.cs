using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PowerTextUpdate : MonoBehaviour
{
    // Start is called before the first frame update
   // public TextMeshProUGUI text;

   public TextMeshProUGUI TextPro;
   public static int mappedPowerValue;

    void Start()
    {
        mappedPowerValue = mapToInt(SliderGet.PowerSliderValue, -0.375, 0.075, 0, 100);  
        TextPro.text = mappedPowerValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        mappedPowerValue = mapToInt(SliderGet.PowerSliderValue, -0.375, 0.075, 0, 100);  
        TextPro.text = mappedPowerValue.ToString();
    }

//hjemmebrygget map funktion
    private int mapToInt(float input, double a, double b, double c, double d){ //a og b er input intervallet og c og d er output intervallet
        double output = c - ( (input - a) / (b-a)) * (c-d);
        //double dOutput = (double)output;
        int intOutput = (int)Math.Round(output, 0, MidpointRounding.AwayFromZero);
        return intOutput;

    }
}
