using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class WolfMovement : MonoBehaviour
{

    //Variables privadas
    [Header("RayCast")]
    //Capa donde quiero que actúe el RayCast
    public LayerMask GroundMask;
    //Longitud del raycast
    public float RayLenght = 0.15f;

    [Header("Jump")]
    public float JumpForce = 200;

    private float _horizontal,
                  _vertical;

    private float _speed = 1.2f,
                  _turnSpeed = 110f;

    private Animator _animator;

    private Rigidbody _rb;

    private Ray _ray;
    private RaycastHit _hit;
    private bool _isGrounded,
                 _canPlayerJump;


    private void Awake() {

        //En esta variable tendremos todo el componente Animator
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();

    }

    void Update() {

        InputPlayer();
        Move();
        Turn();

        Animating();
        CanJump();

    }

    private void FixedUpdate() {

        LaunchRayCast();

        if (_canPlayerJump) {

            _canPlayerJump = false;
            //Saltamos
            Jump();

        }

    }

    private void LaunchRayCast() {

        //El punto de pivote
        _ray.origin = transform.position;
        //hacia abajo
        _ray.direction = -transform.up;

        if (Physics.Raycast(_ray, out _hit, RayLenght)) {

            _isGrounded = true;
            Debug.Log("Estoy tocando el suelo");

        } else {

            _isGrounded=false;

        }

        Debug.DrawRay(_ray.origin, _ray.direction * RayLenght, Color.red);

    }

    private void CanJump() {

        //Si quiero saltar y puedo
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded) {

            _canPlayerJump = true;

        }

    }

    private void Jump() {

        _rb.AddForce(Vector3.up * JumpForce);

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

    private void Animating() {

        if (_vertical != 0) { //El personaje se esta moviendo

            if (_vertical>0) {

                _animator.SetBool("IsMovingForwards", true);

            } else {

                _animator.SetBool("IsMovingBackwards", true);

            }

        } else { //El personaje esta parado

            _animator.SetBool("IsMovingForwards", false);
            _animator.SetBool("IsMovingBackwards", false);

        }

    }

}