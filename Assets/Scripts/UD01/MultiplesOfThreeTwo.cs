using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{

    // Start is called before the first frame update
    void Start() {

        // Ense�amos los multiplos de 3 y 2 del 0 al 100
        ShowMultiplesOfThreeTwo(100);

    }


    // Nos muestra por consola los m�ltiplos de tres y dos del 0 a un determinado n�mero
    private void ShowMultiplesOfThreeTwo(int highestNumber) {

        string messageMultiplesOfThreeTwo = "Los multiplos de 3 y 2 del 0 al " + highestNumber + " son:";

        for (int i = 0; i <= highestNumber; i++) {
            if (i % 3 == 0 || i % 2 == 0) {
                // A�adimos al mensaje los multiplos de 3
                messageMultiplesOfThreeTwo += " " + i;
            }

        }

        Debug.Log(messageMultiplesOfThreeTwo);

    }

}
