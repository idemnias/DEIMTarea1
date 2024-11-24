using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtChicken : MonoBehaviour
{

    //Variables globales
    public Transform MyChicken;

    // Update is called once per frame
    void Update()
    {

        TransformLook();

    }

    private void TransformLook() {

        transform.LookAt(MyChicken);

    }

}
