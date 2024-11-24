using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZombie : MonoBehaviour
{

    private void OnCollisionEnter(Collision infoCollision) {

        Debug.Log(infoCollision.gameObject.tag);

        if (infoCollision.gameObject.tag == "AttackFlower") {

            Destroy(gameObject);

        }

    }


}
