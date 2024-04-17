using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitBoxCamera : MonoBehaviour
{
    public GameObject PlayerCamera;
    public Canvas PlayerCanvas;
    public GameObject BreakerCamera;
    public Canvas BreakerCanvas;

    public GameObject boxLight;
    public Renderer lightCol;
    public Light boxSpot;
    public GameObject screenColour;
    public Renderer lightColour;

    public bool boxOn;

    public Light spotlight1;
    public Light spotlight2;
    public Light spotlight3;

    public GameObject tvScreens;
    public Material mat1;
    public Material mat2;

    public BreakerBoxPuzzle boxPuzzle;

    public bool TVON = false;


    private void Start()
    {
        boxOn = false;

        BreakerCamera.SetActive(false);
        BreakerCanvas.enabled = false;

        lightCol = boxLight.GetComponent<Renderer>();
        boxSpot.color = Color.red;
        lightColour = screenColour.GetComponent<Renderer>();

        spotlight1.enabled = false;
        spotlight2.enabled = false;
        spotlight3.enabled = false;

        tvScreens.GetComponent<MeshRenderer>().material = mat1;

     
    }

    private void Update()
    {
        if (boxPuzzle.wiresConnected == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            PlayerCamera.SetActive(true);
            PlayerCanvas.enabled = true;

            BreakerCamera.SetActive(false);
            BreakerCanvas.enabled = false;

            boxOn = true;

            spotlight1.enabled = true;
            spotlight2.enabled = true;
            spotlight3.enabled = true;

            lightCol.material.SetColor("_EmissionColor", Color.green);
            boxSpot.color = Color.green;
            tvScreens.GetComponent<MeshRenderer>().material = mat2;
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.Confined;
            PlayerCamera.SetActive(false);
            PlayerCanvas.enabled = false;

            BreakerCamera.SetActive(true);
            BreakerCanvas.enabled = true;

            lightColour.material.SetColor("_EmissionColor", Color.green);
            
            
        }
    }

    public bool TVisON (TVON == false)
    {
       if (BreakerCanvas.enabled == true)
        {
            TVON = true;
        }  
    }
}
