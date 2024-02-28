using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitBoxCamera : MonoBehaviour
{
    public GameObject PlayerCamera;
    public GameObject Player;
    public GameObject BreakerCamera;

    public GameObject boxLight;
    public Renderer lightCol;


    private void Start()
    {
        PlayerCamera.SetActive(true);
        BreakerCamera.SetActive(false);
        lightCol = boxLight.GetComponent<Renderer>();
    }

    private void Update()
    {
        // change this to exit when the puzzle is complete \\
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.Locked;
            PlayerCamera.SetActive(true);
            BreakerCamera.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.Confined;
            PlayerCamera.SetActive(false);
            BreakerCamera.SetActive(true);

            lightCol.material.SetColor("_EmissionColor", Color.green);
        }
    }
}
