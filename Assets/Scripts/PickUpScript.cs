using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public GameObject pickupPoint;
    public GameObject pickupTarget;
    public bool isPickedUp;
    public bool paperUp;

    public DoubleDoorsScript doors;


    private void Start()
    {
        doors.GetComponent<DoubleDoorsScript>();
        isPickedUp = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isPickedUp == true)
            {
                pickupTarget.transform.SetParent(null, true);
                isPickedUp = false;
            }
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "pickUp" && Input.GetKey(KeyCode.F) && collision.gameObject.name != "paper")
        {
            if (isPickedUp == false)
            {
                pickupTarget = collision.gameObject;
                pickupTarget.transform.parent = pickupPoint.transform;
                pickupTarget.transform.localPosition = new Vector3(0, 0, 0);
                isPickedUp = true;
            }
        }
        else if (collision.gameObject.name == "paper" && Input.GetKey(KeyCode.F) && doors.woodPlaced == true)
        {
            if (isPickedUp == false)
            {
                paperUp = true;

                pickupTarget = collision.gameObject;
                pickupTarget.transform.parent = pickupPoint.transform;
                pickupTarget.transform.localPosition = new Vector3(0, 0, 0);
                isPickedUp = true;
            }
        }
    }
}
