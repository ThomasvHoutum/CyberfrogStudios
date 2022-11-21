using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTestWin : MonoBehaviour
{
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "PlayerCollider")
        {
            SceneManager.LoadScene(3);
        }
    }
}
