using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    //Los numeros decimales que puede introducir el usuario
    public float NumberOne;
    public float NumberTwo;
    //Booleanos que puede activar el usuario
    public bool IsAddition;
    public bool IsSubtraction;
    public bool IsMultiplication;
    public bool IsDivision;

    // Start is called before the first frame update
    void Start()
    {
        if (IsAddition) Addition(NumberOne, NumberTwo);

        if (IsSubtraction) Subtraction(NumberOne, NumberTwo);

        if (IsMultiplication) Multiplication(NumberOne, NumberTwo);

        if (IsDivision) Division(NumberOne, NumberTwo);
    }

    // Enseñamos el resultado de la suma de dos números por consola
    private void Addition (float numberOne, float numberTwo) {

        float result = numberOne + numberTwo;

        Debug.Log("La suma de " + numberOne + " + " + numberTwo + " = " + result);

    }

    // Enseñamos el resultado de la resta de dos números por consola
    private void Subtraction(float numberOne, float numberTwo) {

        float result = numberOne - numberTwo;

        Debug.Log("La resta de " + numberOne + " - " + numberTwo + " = " + result);

    }

    // Enseñamos el resultado de la multiplicación de dos números por consola
    private void Multiplication(float numberOne, float numberTwo) {

        float result = numberOne * numberTwo;

        Debug.Log("La multiplicación de " + numberOne + " x " + numberTwo + " = " + result);

    }

    // Enseñamos el resultado de la división de dos números por consola
    private void Division(float numberOne, float numberTwo) {

        float result = numberOne / numberTwo;

        Debug.Log("La división de " + numberOne + " / " + numberTwo + " = " + result);

    }
}

