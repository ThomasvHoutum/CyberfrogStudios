using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Rigidbody rb;

    [SerializeField] float speed;

    public int playerHP = 3;

    [SerializeField] GameObject swordCollider;

    [SerializeField] Animator playerAnim;

    [SerializeField] GameObject hp1;
    [SerializeField] GameObject hp2;
    [SerializeField] GameObject hp3;

    [SerializeField] GameObject swordCollider1;
    [SerializeField] GameObject swordCollider2;
    [SerializeField] GameObject swordCollider3;
    [SerializeField] GameObject swordCollider4;
    [SerializeField] GameObject swordCollider5;
    [SerializeField] GameObject swordCollider6;
    [SerializeField] GameObject swordCollider7;
    [SerializeField] GameObject swordCollider8;
    [SerializeField] GameObject swordCollider9;
    [SerializeField] GameObject swordCollider10;

    [SerializeField] Sprite Swing1;
    [SerializeField] Sprite Swing2;
    [SerializeField] Sprite Swing3;
    [SerializeField] Sprite Swing4;
    [SerializeField] Sprite Swing5;
    [SerializeField] Sprite Swing6;
    [SerializeField] Sprite Swing7;
    [SerializeField] Sprite Swing8;
    [SerializeField] Sprite Swing9;
    [SerializeField] Sprite Swing10;

    bool stopMoving;
    
    bool swinging = false;

    bool godMode;
    void FixedUpdate()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed * Time.deltaTime);
        //    GetComponent<SpriteRenderer>().flipX = false;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
        //    GetComponent<SpriteRenderer>().flipX = true;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        //}

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if (stopMoving == false)
        {
        Vector3 tempVect = new Vector3(h, 0, v);
        tempVect = tempVect.normalized * (speed * Time.deltaTime);
        rb.MovePosition(transform.position + tempVect);

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        }



        if (Input.GetKey(KeyCode.F) && swinging == false)
        {
            stopMoving = true;
            playerAnim.SetBool("isSwinging", true);
            swinging = true;
            StartCoroutine("SwingSword");
        }

        if(playerHP == 3)
        {
            hp3.SetActive(true);
        }
        if(playerHP == 2)
        {
            hp3.SetActive(false);
        }
        if(playerHP == 1)
        {
            hp2.SetActive(false);
        }
        if(playerHP == 0)
        {
            SceneManager.LoadScene(4);
        }
    }

    private void Update()
    {
        var playerSprite = GetComponent<SpriteRenderer>().sprite;
        if (swinging == true)
        {
            if (playerSprite == Swing1)
            {
                swordCollider1.SetActive(true);
            }
            if (playerSprite == Swing2)
            {
                swordCollider1.SetActive(false);
                swordCollider2.SetActive(true);
            }
            if (playerSprite == Swing3)
            {
                swordCollider2.SetActive(false);
                swordCollider3.SetActive(true);
            }
            if (playerSprite == Swing4)
            {
                swordCollider3.SetActive(false);
                swordCollider4.SetActive(true);
            }
            if (playerSprite == Swing5)
            {
                swordCollider4.SetActive(false);
                swordCollider5.SetActive(true);
            }
            if (playerSprite == Swing6)
            {
                swordCollider5.SetActive(false);
                swordCollider6.SetActive(true);
            }
            if (playerSprite == Swing7)
            {
                swordCollider6.SetActive(false);
                swordCollider7.SetActive(true);
            }
            if (playerSprite == Swing8)
            {
                swordCollider7.SetActive(false);
                swordCollider8.SetActive(true);
            }
            if (playerSprite == Swing9)
            {
                swordCollider8.SetActive(false);
                swordCollider9.SetActive(true);
            }
            if (playerSprite == Swing10)
            {
                swordCollider9.SetActive(false);
                swordCollider10.SetActive(true);
            }
        }
        else
        {
            swordCollider1.SetActive(false);
            swordCollider2.SetActive(false);
            swordCollider3.SetActive(false);
            swordCollider4.SetActive(false);
            swordCollider5.SetActive(false);
            swordCollider6.SetActive(false);
            swordCollider7.SetActive(false);
            swordCollider8.SetActive(false);
            swordCollider9.SetActive(false);
            swordCollider10.SetActive(false);
        }
        if (Input.GetKey(KeyCode.E))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                if (Input.GetKey(KeyCode.R))
                {
                    godMode = true;
                }
            }
        }
        if(godMode == true)
        {
            playerHP = 3;
            speed = 4;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "BorderX")
        {
            rb.velocity = Vector3.zero;
        }
        if (collision.gameObject.tag == "BorderZ")
        {
            rb.velocity = Vector3.zero;
        }
    }

    IEnumerator SwingSword()
    {
        swordCollider.SetActive(true);
        yield return new WaitForSeconds(1f);
        stopMoving = false;
        playerAnim.SetBool("isSwinging", false);
        swordCollider.SetActive(false);
        swinging = false;
        
    }
}
