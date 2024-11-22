using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{

    //Variables globales
    public Transform MyPlayer;

    // Update is called once per frame
    void Update()
    {

        TransformLook();

    }

    private void TransformLook() {

        transform.LookAt(MyPlayer);

    }

}
