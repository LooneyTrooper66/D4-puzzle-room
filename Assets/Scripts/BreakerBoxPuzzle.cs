using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BreakerBoxPuzzle : MonoBehaviour
{
    public GameObject blueWire;
    public GameObject pinkWire;
    public GameObject whiteWire;

    public Camera cam;
    public LayerMask fuckYou;

    private void Start()
    {
        cam = Camera.main;

        blueWire.SetActive(false);
        whiteWire.SetActive(false);
        pinkWire.SetActive(false);
    }

    public void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = cam.WorldToScreenPoint(mousePos);
        Debug.DrawRay(transform.position, mousePos - transform.position, Color.blue);

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 ray = cam.WorldToScreenPoint(Input.mousePosition);

            if (Physics.Raycast(ray, Vector3.forward, 100, fuckYou))
            {
                Debug.Log("runs2");
                Debug.Log("raycast hit");
            }
            
            
            /*Debug.Log("mouse click");
            RaycastHit hitInfo = new RaycastHit();
            if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hitInfo))
            {
                Debug.Log("did the thing");
                if (hitInfo.transform.tag == "Blue1")
                {
                    print("blue1");
                }
            }*/
        }
    }
}
