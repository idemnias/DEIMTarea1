using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class VectorSum : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        int[] vector1 = new int[5] { 2, 3, 4, 8, 7 };
        int[] vector2 = new int[5] { 1, 2, 3, 4, 5 };
        ShowVectorSum(vector1, vector2);

    }

    //Sacamos por pantalla la suma de dos matrices
    private void ShowVectorSum(int[] vector1, int[] vector2) {

        int[] finalvector = new int[vector1.Length];

        if (vector1.Length != vector2.Length) {
            Debug.Log("El largo de las dos matrices tiene que ser igual");
            return;
        }

        for (int i = 0; i < vector1.Length; i++){
            finalvector[i] = vector1[i] + vector2[i];
        }

        Debug.Log("El resultado de la sumar el vectores es { " + string.Join(", ", vector1) + " } + { " 
            + string.Join(", ", vector2) + " } = { " + string.Join(", ", finalvector) + " }");

    }

}
