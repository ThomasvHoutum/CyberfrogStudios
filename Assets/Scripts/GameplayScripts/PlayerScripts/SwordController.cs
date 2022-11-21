using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour
{

    [SerializeField] GameObject enemyController;

    [SerializeField] 
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "EnemyCollider")
    //    {
    //        enemyController.GetComponent<EnemyController>().HPDown();
    //    }
    //}

    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "EnemyCollider")
        {
            print("Hit " + hit);

            EnemyController enemy = hit.gameObject.GetComponentInParent<EnemyController>();
            enemy.HPDown();
        }
    }
}
