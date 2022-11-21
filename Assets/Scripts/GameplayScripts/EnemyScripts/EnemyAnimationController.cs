using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationController : MonoBehaviour
{
    Animator enemyParentAnim;


    [SerializeField] bool TopLeft;
    [SerializeField] bool Left;
    [SerializeField] bool BottomLeft;
    [SerializeField] bool Bottom;
    [SerializeField] bool BottomRight;
    [SerializeField] bool Right;
    [SerializeField] bool TopRight;
    [SerializeField] bool Top;
    void Update()
    {
        enemyParentAnim = gameObject.GetComponentInParent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerCollider")
        {
            if(TopLeft == true)
            {
                enemyParentAnim.SetBool("PlayerTopRight", false);
                enemyParentAnim.SetBool("PlayerRight", false);
                enemyParentAnim.SetBool("PlayerBottomRight", false);
                enemyParentAnim.SetBool("PlayerFront", false);
                enemyParentAnim.SetBool("PlayerBottomLeft", false);
                enemyParentAnim.SetBool("PlayerLeft", false);
                enemyParentAnim.SetBool("PlayerTopLeft", true);
                enemyParentAnim.SetBool("PlayerBack", false);
            }
            if (Left == true)
            {
                enemyParentAnim.SetBool("PlayerTopRight", false);
                enemyParentAnim.SetBool("PlayerRight", false);
                enemyParentAnim.SetBool("PlayerBottomRight", false);
                enemyParentAnim.SetBool("PlayerFront", false);
                enemyParentAnim.SetBool("PlayerBottomLeft", false);
                enemyParentAnim.SetBool("PlayerLeft", true);
                enemyParentAnim.SetBool("PlayerTopLeft", false);
                enemyParentAnim.SetBool("PlayerBack", false);
            }
            if (BottomLeft == true)
            {
                enemyParentAnim.SetBool("PlayerTopRight", false);
                enemyParentAnim.SetBool("PlayerRight", false);
                enemyParentAnim.SetBool("PlayerBottomRight", false);
                enemyParentAnim.SetBool("PlayerFront", false);
                enemyParentAnim.SetBool("PlayerBottomLeft", true);
                enemyParentAnim.SetBool("PlayerLeft", false);
                enemyParentAnim.SetBool("PlayerTopLeft", false);
                enemyParentAnim.SetBool("PlayerBack", false);
            }
            if (Bottom == true)
            {
                enemyParentAnim.SetBool("PlayerTopRight", false);
                enemyParentAnim.SetBool("PlayerRight", false);
                enemyParentAnim.SetBool("PlayerBottomRight", false);
                enemyParentAnim.SetBool("PlayerFront", true);
                enemyParentAnim.SetBool("PlayerBottomLeft", false);
                enemyParentAnim.SetBool("PlayerLeft", false);
                enemyParentAnim.SetBool("PlayerTopLeft", false);
                enemyParentAnim.SetBool("PlayerBack", false);
            }
            if (BottomRight == true)
            {
                enemyParentAnim.SetBool("PlayerTopRight", false);
                enemyParentAnim.SetBool("PlayerRight", false);
                enemyParentAnim.SetBool("PlayerBottomRight", true);
                enemyParentAnim.SetBool("PlayerFront", false);
                enemyParentAnim.SetBool("PlayerBottomLeft", false);
                enemyParentAnim.SetBool("PlayerLeft", false);
                enemyParentAnim.SetBool("PlayerTopLeft", false);
                enemyParentAnim.SetBool("PlayerBack", false);
            }
            if (Right == true)
            {
                enemyParentAnim.SetBool("PlayerTopRight", false);
                enemyParentAnim.SetBool("PlayerRight", true);
                enemyParentAnim.SetBool("PlayerBottomRight", false);
                enemyParentAnim.SetBool("PlayerFront", false);
                enemyParentAnim.SetBool("PlayerBottomLeft", false);
                enemyParentAnim.SetBool("PlayerLeft", false);
                enemyParentAnim.SetBool("PlayerTopLeft", false);
                enemyParentAnim.SetBool("PlayerBack", false);
            }
            if (TopRight == true)
            {
                enemyParentAnim.SetBool("PlayerTopRight", true);
                enemyParentAnim.SetBool("PlayerRight", false);
                enemyParentAnim.SetBool("PlayerBottomRight", false);
                enemyParentAnim.SetBool("PlayerFront", false);
                enemyParentAnim.SetBool("PlayerBottomLeft", false);
                enemyParentAnim.SetBool("PlayerLeft", false);
                enemyParentAnim.SetBool("PlayerTopLeft", false);
                enemyParentAnim.SetBool("PlayerBack", false);
            }
            if (Top == true)
            {
                enemyParentAnim.SetBool("PlayerTopRight", false);
                enemyParentAnim.SetBool("PlayerRight", false);
                enemyParentAnim.SetBool("PlayerBottomRight", false);
                enemyParentAnim.SetBool("PlayerFront", false);
                enemyParentAnim.SetBool("PlayerBottomLeft", false);
                enemyParentAnim.SetBool("PlayerLeft", false);
                enemyParentAnim.SetBool("PlayerTopLeft", false);
                enemyParentAnim.SetBool("PlayerBack", true);
            }
        }
    }
}
