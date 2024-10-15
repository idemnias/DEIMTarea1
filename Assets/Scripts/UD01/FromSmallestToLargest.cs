using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    // Variables privadas
    [SerializeField]
    private int _number1;
    [SerializeField]
    private int _number2;
    [SerializeField]
    private int _number3;

    // Start is called before the first frame update
    void Start()
    {

        ShowOrdererList();

    }

    // Mostramos la lista ordenada por consola
    private void ShowOrdererList() {

        string messageOrderedList = "Los numeros ordenados son estes" ;

        List<int> orderedList = new List<int>{ _number1, _number2, _number3 };

        //Ordenamos la lista
        orderedList.Sort();

        foreach (int item in orderedList){
            // Añadimos los numeros al mensaje
            messageOrderedList += " " + item;
        }

        Debug.Log(messageOrderedList);
    }

}
