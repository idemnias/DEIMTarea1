using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pair : MonoBehaviour
{

    // Start is called before the first frame update
    void Start() 
    {

        // Mostramos los numeros pares entre 0 y 100
        ShowPairNumbers(100);

    }


    // Muestra todos los numeros pares entre el 0 y un número.
    private void ShowPairNumbers(int highestNumber) {

        string messagePairNumbers = "Los numeros pares son";

        for (int i = 0; i <= highestNumber; i++) {

            if (i % 2 == 0) {
                // Vamos añadiendo los numeros pares al mensaje
                messagePairNumbers += " " + i;
            }

        }

        Debug.Log(messagePairNumbers);

    }

}
