using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public PickUpScript pickUp;
    public GameObject pickedUp;
    public bool p1Full;
    public bool p2Full;

    public CircuitBoxCamera breakerBox;


    private void Start()
    {
        p1Full = false;
        p2Full = false;
    }

    private void OnTriggerStay(Collider collision)
    {
        if (breakerBox.boxOn == true)
        {
            if (collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
            {
                if (pickUp.isPickedUp == true && pickUp.pickupTarget.name != "paper")
                {
                    pickedUp = pickUp.pickupTarget;

                    if (pickUp.pickupTarget.name == "plank1")
                    {
                        place1();
                    }
                    else if (pickUp.pickupTarget.name == "plank2")
                    {
                        place2();
                    }
                }
            }
        }
    }

    void place1()
    {
        pickedUp.transform.position = new Vector3(6.4f, 3.75f, -8.85f);
        pickedUp.transform.rotation = Quaternion.Euler(0f, 0f, 5f);
        pickedUp.tag = "Untagged";
        p1Full = true;
    }

    void place2()
    {
        pickedUp.transform.position = new Vector3(6.4f, 1.8f, -8.85f);
        pickedUp.transform.rotation = Quaternion.Euler(0f, 0f, -10f);
        pickedUp.tag = "Untagged";
        p2Full = true;
    }
}
