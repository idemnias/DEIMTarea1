using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    // Variables privadas
    [SerializeField]
    private int _number10;
    [SerializeField]
    private int _number11;
    [SerializeField]
    private int _number12;

    // Start is called before the first frame update
    void Start() {

        if (IsInverseOrdererNumbers()) {
            Debug.Log("Los numeros están ordenados descendentemente");
        } else {
            Debug.Log("Los numeros no están ordenados descendentemente");
        }

    }

    // Comprobamos si la lista esta ordenada
    private bool IsInverseOrdererNumbers() {

        return (_number10 >= _number11 && _number11 >= _number12) ? true : false;

    }
}
