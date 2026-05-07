// © 2026 Radioxians Studios. All Rights Reserved.
// v 1.0
//  You can study observe, modify and use it on your game, but not publish it, or sell it; it will violate the copyright (©) of Radioxians Studios.
// This script is on Git Hub


using System.Collections;
using UnityEngine;

public class Tutorial2 : MonoBehaviour
{
    public int bread = 3;

    public float number = 2;

    public float number2 = 3;

    public string sandwich = "paninoblop";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (number != 3 && (number2 == 2 || sandwich == "paninoblop"))
        {
            Debug.Log("number is not 3, number2 is 2 or sandwich is paninoblop!");
        }
        else
        {
            Debug.Log("NOT OK!");
        }

        switch (bread)
        {
            case 1:
                Debug.Log("OK");
                break;

            case 2:
                Debug.Log("OKOKOKOK");
                break;

            default:
                Debug.Log("nothing selected");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}