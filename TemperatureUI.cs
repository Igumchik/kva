using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TemperatureUI : MonoBehaviour
{
    public Temperature temperature;
    public TextMeshProUGUI degreesText;

    // Update is called once per frame
    void Update()
    {
        float roundedTemperature = Mathf.Round(temperature.temperatureCurrent * 10.0f) * 0.1f;
        degreesText.text = roundedTemperature.ToString();
    }
}
