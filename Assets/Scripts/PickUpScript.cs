using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public GameObject pickupPoint;
    public GameObject pickupTarget;
    private bool isPickedUp;


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
        if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.F))
        {
            if (isPickedUp == false)
            {
                pickupTarget.transform.parent = pickupPoint.transform;
                pickupTarget.transform.localPosition = new Vector3(0, 0, 0);
                isPickedUp = true;
            }
        }
    }
}
