using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Addition : MonoBehaviour
{

    // Variables privadas
    [SerializeField]
    private int _highestNumber;

    // Start is called before the first frame update
    void Start()
    {

        ShowSumOfConsecutiveNumbers(_highestNumber);

    }

    // Mostramos por consola la suma de números consecutivos desde el 1 hasta un número 
    private void ShowSumOfConsecutiveNumbers(int highestNumber) {

        int addition = 0;

        for (int i = 1; i <= highestNumber; i++){
            addition += i;
        }

        Debug.Log("La suma de todos los números del 1 al " + highestNumber + " es " + addition);

    }

}
