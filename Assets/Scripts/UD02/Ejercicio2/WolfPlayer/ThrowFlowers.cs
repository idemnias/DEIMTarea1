using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFlowers : MonoBehaviour {

    //Variables globales
    public GameObject Flower;
    public Transform PosRotFlower;

    public float ThrustY = 100f,
                 ThrustZ = 300f;
    private float _timeFlower = 3f;

    // Update is called once per frame
    void Update() {

        CreateFlower();

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
}
