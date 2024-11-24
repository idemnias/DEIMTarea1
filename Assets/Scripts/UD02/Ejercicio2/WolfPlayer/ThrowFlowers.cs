using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class ThrowFlowers : MonoBehaviour {

    //Variables globales
    public GameObject Flower;
    public Transform PosRotFlower;

    public float ThrustY = 100f,
                 ThrustZ = 300f;
    private float _timeFlower = 3f;

    private Animator _animator;

    private void Awake() {

        _animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update() {

        CreateFlower();
        AnimationAttack();

    }

    private void CreateFlower() {

        if (Input.GetMouseButtonDown(0)) {

            //Crear clones de flores
            GameObject cloneFlower = Instantiate(Flower, PosRotFlower.position, PosRotFlower.rotation);

            //Obtengo el componente de "rigibody" de la flor
            Rigidbody rbFlower = cloneFlower.GetComponent<Rigidbody>();

            cloneFlower.tag = "AttackFlower";

            //Se da la fuerza para lanzar las flores en parábola
            rbFlower.AddForce(Vector3.up * ThrustY);
            rbFlower.AddForce(transform.forward * ThrustZ );

            Destroy(cloneFlower, _timeFlower);

        }

    }

    private void AnimationAttack() {

        if (Input.GetMouseButtonDown(0)) {

            //Ejecución de la animación
            _animator.SetTrigger("Attack");

        }

    }

}
