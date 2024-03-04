using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public GameObject pickupPoint;
    public GameObject pickupTarget;
    public bool isPickedUp;


    private void Start()
    {
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
        if (collision.gameObject.tag == "pickUp" && Input.GetKey(KeyCode.F))
        {
            if (isPickedUp == false)
            {
                pickupTarget = collision.gameObject;
                pickupTarget.transform.parent = pickupPoint.transform;
                pickupTarget.transform.localPosition = new Vector3(0, 0, 0);
                isPickedUp = true;
            }
        }
    }
}
