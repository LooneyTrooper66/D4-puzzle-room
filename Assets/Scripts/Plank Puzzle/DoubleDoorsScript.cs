using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleDoorsScript : MonoBehaviour
{
    public PickUpScript pickUp;
    public GameObject pickedUp;
    public bool p3Full;
    public bool p4Full;
    public bool p5Full;

    public CircuitBoxCamera breakerBox;
    public DoorScript doorsBool;
    public bool woodPlaced;


    private void Start()
    {
        p3Full = false;
        p4Full = false;
        p5Full = false;
        woodPlaced = false;
    }

    private void Update()
    {
        if (doorsBool.p1Full == true && doorsBool.p2Full == true && p3Full == true && p4Full == true && p5Full == true)
        {
            woodPlaced = true;
            /*JoshDialogueScript joshDS = beanCanvas.GetComponent<JoshDialogueScript>();

            joshDS.Planks();*/
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (breakerBox.boxOn == true)
        {
            if (collision.gameObject.tag == "Player")
            {
                if (pickUp.isPickedUp == true && pickUp.pickupTarget.name != "paper")
                {
                    pickedUp = pickUp.pickupTarget;

                    if (pickUp.pickupTarget.name == "plank3")
                    {
                        place3();
                    }
                    else if (pickUp.pickupTarget.name == "plank4")
                    {
                        place4();
                    }
                    else if (pickUp.pickupTarget.name == "plank5")
                    {
                        place5();
                    }
                }
            }
        }
    }

    void place3()
    {
        pickedUp.transform.position = new Vector3(-13.947f, 1f, 8.566f);
        pickedUp.transform.rotation = Quaternion.Euler(-180f, -68.5f, 5f);
        pickedUp.tag = "Untagged";
        p3Full = true;
    }

    void place4()
    {
        pickedUp.transform.position = new Vector3(-13.947f, 2.5f, 8.566f);
        pickedUp.transform.rotation = Quaternion.Euler(-180f, -68.5f, -10f);
        pickedUp.tag = "Untagged";
        p4Full = true;
    }

    void place5()
    {
        pickedUp.transform.position = new Vector3(-13.947f, 4.2f, 8.566f);
        pickedUp.transform.rotation = Quaternion.Euler(-180f, -68.5f, 10f);
        pickedUp.tag = "Untagged";
        p5Full = true;
    }
}
