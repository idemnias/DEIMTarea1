using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAxis : MonoBehaviour
{

    //Variables privadas
    private float _horizontal,
                  _vertical;

    private float _speed = 0.8f,
                  _turnSpeed = 90f;

    void Update()
    {

        InputPlayer();
        Move();
        Turn();

    }

    private void InputPlayer() {

        //Teclas A y D y las flechas < y >
        _horizontal = Input.GetAxis("Horizontal");

        //Teclas W y S y las flechas arriba y abajo de la cruceta de nuestro teclado
        _vertical = Input.GetAxis("Vertical");

    }

    private void Move() {

        // Aplicamos el eje vertical
        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);

    }

    private void Turn() {

        // Aplicamos el eje horizontal
        transform.Rotate(Vector3.up * _horizontal * _turnSpeed * Time.deltaTime);

    }

}
