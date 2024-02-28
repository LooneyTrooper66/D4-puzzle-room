using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetectionScript : MonoBehaviour
{
    public GameObject PlayerCamera;
    public GameObject Player;
    public GameObject PinballCamera;
    public bool playingPinball;


    private void Start()
    {
        PlayerCamera.SetActive(true);
        PinballCamera.SetActive(false);
        playingPinball = false;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            PlayerCamera.SetActive(true);
            PinballCamera.SetActive(false);
            playingPinball = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKey(KeyCode.F))
        {
            PlayerCamera.SetActive(false);
            PinballCamera.SetActive(true);
            playingPinball = true;
        }
    }
}
