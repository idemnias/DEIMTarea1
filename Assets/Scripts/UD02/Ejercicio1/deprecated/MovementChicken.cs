using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovementChicken : MonoBehaviour
{
    // Variables privadas
    [SerializeField]
    private float _speed = 0.8f;

    [SerializeField]
    private float _speedRotate = 90f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector3.back * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(Vector3.up * _speedRotate * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(Vector3.down * _speedRotate * Time.deltaTime);
        }
    }
}
