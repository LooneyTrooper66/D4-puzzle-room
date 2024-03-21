using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PinballTimerUpdate : MonoBehaviour
{
    public Text controls;

    public TriggerDetectionScript pinball;


    private void Start()
    {
        controls.text = "Left Click - Select \nF - Pick Up / Interact \nE - Drop";
    }

    private void Update()
    {
        if (pinball.playingPinball == true)
        {
            controls.text = "A - Left Flipper \nL - Right Flipper \nLCtrl - Spawn Ball \nX - Destroy Ball";
        }
    }
}
