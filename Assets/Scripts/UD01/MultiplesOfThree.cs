using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        // Ense�amos los multiplos de 3 del 0 al 100
        ShowMultiplesOfThree(100);

    }


    // Nos muestra por consola los m�ltiplos de tres del 0 a un determinado n�mero
    private void ShowMultiplesOfThree(int highestNumber) {

        string messageMultiplesOfThree = "Los multiplos de 3 del 0 al " + highestNumber + " son:";

        for (int i = 0; i <= highestNumber; i++)
        {
            if(i % 3 == 0) {
                // A�adimos al mensaje los multiplos de 3
                messageMultiplesOfThree += " " + i;
            }

        }

        Debug.Log(messageMultiplesOfThree);

    }

}
