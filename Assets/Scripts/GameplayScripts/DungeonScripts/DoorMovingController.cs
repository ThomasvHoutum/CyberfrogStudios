using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovingController : MonoBehaviour
{
    [SerializeField] GameObject thisDoor;
    [SerializeField] GameObject NextRoomCollider;

    [SerializeField] float speed;

    [SerializeField] float maxHeight;
    [SerializeField] float maxDepth;

    public bool doorGoUp;
    public bool doorGoDown;
    void Update()
    { 
        if(doorGoUp == true)
        {
            thisDoor.transform.position = new Vector3(thisDoor.transform.position.x, thisDoor.transform.position.y + (speed * Time.deltaTime), thisDoor.transform.position.z);
        }
        if (doorGoDown == true)
        {
            thisDoor.transform.position = new Vector3(thisDoor.transform.position.x, thisDoor.transform.position.y - (speed * Time.deltaTime), thisDoor.transform.position.z);
        }

        if (thisDoor.transform.position.y >= maxHeight)
        {
            doorGoUp = false;
            NextRoomCollider.SetActive(true);
        }
        if(thisDoor.transform.position.y <= maxDepth)
        {
            doorGoDown = false;
            NextRoomCollider.SetActive(false);
        }
    }
}
