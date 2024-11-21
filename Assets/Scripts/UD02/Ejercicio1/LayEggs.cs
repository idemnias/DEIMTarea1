using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayEggs : MonoBehaviour {

    //Variables globales
    public GameObject Egg;
    public Transform PosEgg;

    public float ThrustY = 30f,
                 ThrustZ = 70f;
    private float _timeEgg = 5f;

    // Update is called once per frame
    void Update() {

        CreateEgg();

    }

    private void CreateEgg() {

        if (Input.GetMouseButtonDown(0)) {

            //Crear clones de huevos
            GameObject cloneEgg = Instantiate(Egg, PosEgg.position, PosEgg.rotation);

            //Obtengo el componente de "rigibody" del huevo
            Rigidbody rbEgg = cloneEgg.GetComponent<Rigidbody>();

            //Se da la fuerza para poner los huevos
            //La fuerza en el eje Z sera en negativo para que se lanze hacia atras
            rbEgg.AddForce(Vector3.up * ThrustY);
            rbEgg.AddForce(transform.forward * -ThrustZ );

            Destroy(cloneEgg, _timeEgg);

        }

    }
}
