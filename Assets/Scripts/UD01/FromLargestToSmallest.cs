using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{
    // Variables privadas
    [SerializeField]
    private int _number4;
    [SerializeField]
    private int _number5;
    [SerializeField]
    private int _number6;

    // Start is called before the first frame update
    void Start() {

        ShowReverseOrderedList();

    }

    // Mostramos la lista ordenada descendentemente por consola
    private void ShowReverseOrderedList() {

        string messageOrderedList = "Los numeros ordenados descendentemente son estes";

        List<int> orderedList = new List<int> { _number4, _number5, _number6 };

        // Ordenamos la lista
        orderedList.Sort();
        // Invertimos el orden
        orderedList.Reverse();

        foreach (int item in orderedList) {
            // Añadimos los numeros al mensaje
            messageOrderedList += " " + item;
        }

        Debug.Log(messageOrderedList);
    }
}
