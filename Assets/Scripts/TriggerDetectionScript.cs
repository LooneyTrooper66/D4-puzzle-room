using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetectionScript : MonoBehaviour
{
    public GameObject PlayerCamera;
    public GameObject Player;
    public GameObject PinballCamera;
    public bool playingPinball;

    public KeycodePuzzleRaycastScript buttonCheck;


    private void Start()
    {
        playingPinball = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (buttonCheck.buttonOn == true)
        {
            if (other.gameObject.tag == "Player" && Input.GetKey(KeyCode.F))
            {
                PlayerCamera.SetActive(false);
                playingPinball = true;
            }
        }
    }
}
