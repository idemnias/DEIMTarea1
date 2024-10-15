using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Odd : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        // Mostramos los numeros impares entre 0 y 100
        ShowOddNumbers(100);

    }


    // Muestra todos los numeros impares entre 0 y un n�mero.
    private void ShowOddNumbers(int highestNumber) {

        string messageOddNumbers = "Los numeros impares son";

        for (int i = 0; i <= highestNumber; i++){

            if (i % 2 != 0) {
                // Vamos a�adiendo los numeros impares al mensaje
                messageOddNumbers += " " + i;
            }

        }

        Debug.Log(messageOddNumbers);

    }

}
