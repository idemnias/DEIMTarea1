using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraWolfFollow : MonoBehaviour
{
    //Variables globales
    public Transform Target;
    //Velocidad de seguimiento que va a tener la camara
    public float _smoothing = 2f;
    //Distancia inicial entre el "Target" y la cámara
    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        //El "offset" es igual a la posición de la cámara menos
        //la del "player". Realmente es el Vector que los une
        _offset = transform.position - Target.position;

    }

    // Update is called once per frame
    void Update()
    {
        
        //La posicion a al que quiero mover la cámara
        transform.position = Vector3.Lerp(transform.position,Target.position + _offset, _smoothing * Time.deltaTime);

    }

}
