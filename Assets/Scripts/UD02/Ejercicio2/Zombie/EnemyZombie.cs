using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZombie : MonoBehaviour
{

    private void OnTriggerEnter(Collider infoAccess) {

        Debug.Log(infoAccess.gameObject.tag);

        if (infoAccess.CompareTag("AttackFlower")) {

            Destroy(gameObject);

        }

    }

}
