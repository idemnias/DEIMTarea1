using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{
    //Variables privadas
    [SerializeField]
    private byte _month = 0;

    // Start is called before the first frame update
    void Start()
    {

        // Mostrar por pantalla el mensaje del mes seleccionado
        Debug.Log(GetMonth());

    }

    //Obtener el mensaje del mes elegido desde el inspector
    private string GetMonth() {

        string selectedMonthMessage = "Ha seleccionado el mes de ";

        switch (_month) {

            case 1:
                return selectedMonthMessage + "Enero";
            case 2:
                return selectedMonthMessage + "Febrero";
            case 3:
                return selectedMonthMessage + "Marzo";
            case 4:
                return selectedMonthMessage + "Abril";
            case 5:
                return selectedMonthMessage + "Mayo";
            case 6:
                return selectedMonthMessage + "Junio";
            case 7:
                return selectedMonthMessage + "Julio";
            case 8:
                return selectedMonthMessage + "Agosto";
            case 9:
                return selectedMonthMessage + "Septiembre";
            case 10:
                return selectedMonthMessage + "Octubre";
            case 11:
                return selectedMonthMessage + "Noviembre";
            case 12:
                return selectedMonthMessage + "Diciembre";
            default:
                return "[Mes no soportado] Debe de seleccionar un numero del 1 al 12";

        }

    }

}
