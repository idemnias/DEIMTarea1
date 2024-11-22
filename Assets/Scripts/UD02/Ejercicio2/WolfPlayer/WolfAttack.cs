using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAttack : MonoBehaviour
{
    //Variables globales
    private Animator _animator;

    private void Awake() {
        
        _animator = GetComponent<Animator>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)) {

            Attack();

        }
        
    }

    private void Attack() {

        //Ejecución de la animación
        _animator.SetTrigger("Attack");

    }

}
