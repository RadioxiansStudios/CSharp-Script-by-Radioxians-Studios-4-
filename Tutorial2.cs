using System.Collections;
using UnityEngine;

public class Tutorial2 : MonoBehaviour
{

    public float pane = 3;
    
    public float numero = 2;

    public float numero2 = 3;

    public string panino = "paninoblop";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (numero != 3 && (numero2 == 2 || panino == "paninoblop"))
        {
            Debug.Log("numero non è 3, numero2 è 2 o panino è paninoblop!");
        }
        else
        {
            Debug.Log("NON MI VA BENE!");     
        }

        switch(pane)
        {
            case 1:
                 Debug.Log("OK");
                 break;
            
            case 2:
                 Debug.Log("OKOKOKOK");
                 break;

            default:
                  Debug.Log("niente selezionato");
                  break;
                 
        }

    }

    // Update is called once per frame
    void Update()
    {
        


        
    }
}
