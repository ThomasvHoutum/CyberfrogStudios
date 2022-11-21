using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollider : MonoBehaviour
{
    [SerializeField] GameObject player;
    private void OnTriggerEnter(Collider hit)
    {
        if(hit.gameObject.tag == "PlayerCollider")
        {
            PlayerHit();
        }
    }

    public void PlayerHit()
    {
        player.GetComponent<PlayerController>().playerHP--;
    }

    private void Update()
    {
        player = GameObject.FindWithTag("Player");
    }
}
