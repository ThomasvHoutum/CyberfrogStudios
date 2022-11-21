using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] GameObject dungeonController;

    public int nextRoomNumber;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerCollider")
        {
            dungeonController.GetComponent<DungeonController>().NextRoom(nextRoomNumber);
        }
    }
}
