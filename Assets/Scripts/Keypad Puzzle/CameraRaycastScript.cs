using UnityEngine;

public class CameraRaycastScript : MonoBehaviour
{
    public Camera playerCam;
    public KeyCodeScript keyCodeScr;
    public string currentKey;

    public DoubleDoorsScript doubleDoors;
    public KeyCodeScript keycode;
    public bool buttonOn;

    public GameObject smallColour;
    public Renderer lightColour;

    public Light spotlight;
    public Light neon1;
    public Light neon2;
    public Light neon3;
    public Light neon4;


    private void Start()
    {
        lightColour = smallColour.GetComponent<Renderer>();
        buttonOn = false;

        spotlight.enabled = false;
        neon1.enabled = false;
        neon2.enabled = false;
        neon3.enabled = false;
        neon4.enabled = false;
    }

    void Update()
    {
        //Debug.DrawRay(playerCam.transform.position, playerCam.transform.forward, Color.blue);

        if (Input.GetButtonDown("Fire1"))
        {
            if (keyCodeScr.codeCorrect == false && doubleDoors.woodPlaced == true)
            {
                Key();
                keyCodeScr.Passcode(currentKey);
            }
            else if (keyCodeScr.codeCorrect == true && doubleDoors.woodPlaced == true)
            {
                Button();
            }
        }
    }

    void Button()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 100f))
        {
            if (hit.transform.name == "button")
            {
                lightColour.material.SetColor("_EmissionColor", Color.green);
                buttonOn = true;

                spotlight.enabled = true;
                neon1.enabled = true;
                neon2.enabled = true;
                neon3.enabled = true;
                neon4.enabled = true;
            }
        }
    }

    void Key()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 100f))
        {
            // please scott have mercy on me for what im about to do \\
            if (hit.transform.name == "key1")
            {
                currentKey = "1";
            }
            else if (hit.transform.name == "key2")
            {
                currentKey = "2";
            }
            else if (hit.transform.name == "key3")
            {
                currentKey = "3";
            }
            else if (hit.transform.name == "key4")
            {
                currentKey = "4";
            }
            else if (hit.transform.name == "key5")
            {
                currentKey = "5";
            }
            else if (hit.transform.name == "key6")
            {
                currentKey = "6";
            }
            else if (hit.transform.name == "key7")
            {
                currentKey = "7";
            }
            else if (hit.transform.name == "key8")
            {
                currentKey = "8";
            }
            else if (hit.transform.name == "key9")
            {
                currentKey = "9";
            }
        }
    }
}
