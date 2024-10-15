using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    // Variables privadas
    [SerializeField]
    private int _number7;
    [SerializeField]
    private int _number8;
    [SerializeField]
    private int _number9;

    // Start is called before the first frame update
    void Start() {

        if (IsOrdererNumbers()) {
            Debug.Log("Los numeros están ordenados");
        } else {
            Debug.Log("Los numeros no están ordenados");
        }

    }

    // Comprobamos si la lista esta ordenada
    private bool IsOrdererNumbers() {

        return (_number7 <= _number8 && _number8 <= _number9) ? true : false; 

    }
}
