using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackController : MonoBehaviour
{
    Animator enemyParentAnim;

    GameObject player;

    [SerializeField] bool Left;
    [SerializeField] bool Bottom;
    [SerializeField] bool Right;
    [SerializeField] bool Top;
    void Update()
    {
        enemyParentAnim = gameObject.GetComponentInParent<Animator>();

        player = GameObject.FindWithTag("Player");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerCollider")
        {
            StartCoroutine("Attack");
            

            //enemyParentAnim.SetBool("Moving", false);
            //if(TopLeft == true)
            //{
            //    enemyParentAnim.SetBool("AttackTop", true);
            //}
        }
    }

    IEnumerator Attack()
    {
        enemyParentAnim.SetBool("Moving", false);
        if(Top == true)
        {
            player.GetComponent<PlayerController>().playerHP--;

            enemyParentAnim.SetBool("AttackTop", true);

            enemyParentAnim.SetBool("PlayerTopRight", false);
            enemyParentAnim.SetBool("PlayerRight", false);
            enemyParentAnim.SetBool("PlayerBottomRight", false);
            enemyParentAnim.SetBool("PlayerFront", false);
            enemyParentAnim.SetBool("PlayerBottomLeft", false);
            enemyParentAnim.SetBool("PlayerLeft", false);
            enemyParentAnim.SetBool("PlayerTopLeft", false);
            enemyParentAnim.SetBool("PlayerBack", false);

            yield return new WaitForSeconds(1);
            enemyParentAnim.SetBool("AttackTop", false);
            enemyParentAnim.SetBool("Moving", true);
        }
        if (Right == true)
        {
            player.GetComponent<PlayerController>().playerHP--;

            enemyParentAnim.SetBool("AttackRight", true);

            enemyParentAnim.SetBool("PlayerTopRight", false);
            enemyParentAnim.SetBool("PlayerRight", false);
            enemyParentAnim.SetBool("PlayerBottomRight", false);
            enemyParentAnim.SetBool("PlayerFront", false);
            enemyParentAnim.SetBool("PlayerBottomLeft", false);
            enemyParentAnim.SetBool("PlayerLeft", false);
            enemyParentAnim.SetBool("PlayerTopLeft", false);
            enemyParentAnim.SetBool("PlayerBack", false);

            yield return new WaitForSeconds(1);
            enemyParentAnim.SetBool("AttackRight", false);
            enemyParentAnim.SetBool("Moving", true);
        }
        if (Bottom == true)
        {
            player.GetComponent<PlayerController>().playerHP--;

            enemyParentAnim.SetBool("AttackDown", true);

            enemyParentAnim.SetBool("PlayerTopRight", false);
            enemyParentAnim.SetBool("PlayerRight", false);
            enemyParentAnim.SetBool("PlayerBottomRight", false);
            enemyParentAnim.SetBool("PlayerFront", false);
            enemyParentAnim.SetBool("PlayerBottomLeft", false);
            enemyParentAnim.SetBool("PlayerLeft", false);
            enemyParentAnim.SetBool("PlayerTopLeft", false);
            enemyParentAnim.SetBool("PlayerBack", false);

            yield return new WaitForSeconds(1);
            enemyParentAnim.SetBool("AttackDown", false);
            enemyParentAnim.SetBool("Moving", true);
        }
        if (Left == true)
        {
            player.GetComponent<PlayerController>().playerHP--;

            enemyParentAnim.SetBool("AttackLeft", true);

            enemyParentAnim.SetBool("PlayerTopRight", false);
            enemyParentAnim.SetBool("PlayerRight", false);
            enemyParentAnim.SetBool("PlayerBottomRight", false);
            enemyParentAnim.SetBool("PlayerFront", false);
            enemyParentAnim.SetBool("PlayerBottomLeft", false);
            enemyParentAnim.SetBool("PlayerLeft", false);
            enemyParentAnim.SetBool("PlayerTopLeft", false);
            enemyParentAnim.SetBool("PlayerBack", false);

            yield return new WaitForSeconds(1);
            enemyParentAnim.SetBool("AttackLeft", false);
            enemyParentAnim.SetBool("Moving", true);
        }
        else
        {
            enemyParentAnim.SetBool("Moving", true);
            enemyParentAnim.SetBool("AttackTop", false);
            enemyParentAnim.SetBool("AttackLeft", false);
            enemyParentAnim.SetBool("AttackRight", false);
            enemyParentAnim.SetBool("AttackDown", false);
        }
    }
}
