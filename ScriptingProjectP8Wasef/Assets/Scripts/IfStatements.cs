using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotlimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
        coffeeTemperature -= Time.deltaTime * 5f;
    }
    void TemperatureTest()
    {
        //If the coffee's temperature is greater than the hottest drinking temperture...
        if (coffeeTemperature > hotlimitTemperature)
        {
            //...do this
            print("Coffee is too hot.");
        }
        //if it isn't, but the coffee temperature is less than the coldest drinking temperture...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            //...do this.
            print("Coffee is too cold");
        }
        // If it is neither of those then...
        else
        {

            //...do this.
            print("Coffee is just right.");
        }
    }
}
