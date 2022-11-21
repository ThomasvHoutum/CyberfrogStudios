using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class EnemyController : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject dungeonController;
    [SerializeField] Animator enemyAnim;

    [SerializeField] float speed;

    public bool enemyMoving = true;

    public int EnemyHP = 1;

    Vector3 moveToVector;

    private void Start()
    {
        EnemyHP = 1;
    }
    void Update()
    {
        player = GameObject.FindWithTag("Player");
        dungeonController = GameObject.FindWithTag("EventSystem");
        moveToVector = new Vector3(player.transform.position.x, 1.35f, player.transform.position.z);

        if(enemyAnim.GetBool("Moving") == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, moveToVector, speed * Time.deltaTime);
        }

        if(EnemyHP <= 0)
        {
            Destroy(this.gameObject);
            dungeonController.GetComponent<DungeonController>().killCounter++;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "SwordCollider")
        {
            HPDown();
        }
    }


    public void HPDown()
    {
        EnemyHP--;
    }
}
