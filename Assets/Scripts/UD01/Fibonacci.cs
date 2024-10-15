using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fibonacci : MonoBehaviour
{

    //Variables privadas
    [SerializeField]
    private int _fibonacciPosition;

    // Start is called before the first frame update
    void Start() 
    {
            
        GetNumberByPositionOfFibonacciSequence();

    }

    //Mostramos el número de la secuencia de Fibonacci en base a la posición
    private void GetNumberByPositionOfFibonacciSequence() {

        if (_fibonacciPosition < 0) {
            Debug.Log("El número tiene que ser mayor o igual a 0");
            return; // Salir del método
        }

        // Posición en la que no encontramos
        int position=0;
        int fibonacciNumber = 1;
        int previousFibonacciNumber = 0;

        //recorremos posiciciones y comprobamos 
        while (position < _fibonacciPosition) {
            int numberPreviousTemporary = fibonacciNumber; // guardamos en numero de fibonacci en un numero temporal
            fibonacciNumber += previousFibonacciNumber; //Es el valor para esta posición
            previousFibonacciNumber = numberPreviousTemporary; //Actualizamos el numero previo para que este preparado para la siguiente posición
            position++;
        }

        //Las dos primeras posiciones tienen valores fijos y no vale el calculo
        if (_fibonacciPosition == 0) {
            Debug.Log("El numero calculado en la posicion " + _fibonacciPosition + " en la sequencia de Fibonacci es " + 0);
        } else if (_fibonacciPosition == 1) {
            Debug.Log("El numero calculado en la posicion " + _fibonacciPosition + " en la sequencia de Fibonacci es " + 1);
        } else {
            Debug.Log("El numero calculado en la posicion " + _fibonacciPosition + " en la sequencia de Fibonacci es " + fibonacciNumber);
        }

    }

}
