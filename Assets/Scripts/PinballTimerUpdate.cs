using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PinballTimerUpdate : MonoBehaviour
{
    public Text controls;

    public TriggerDetectionScript pinball;
    public CircuitBoxCamera circuitCam;
    public PauseMenu paused;


    private void Update()
    {
        if (paused.isPaused == true)
        {
            controls.text = "Esc - Unpause";
        }
        else if (pinball.playingPinball == true && paused.isPaused == false)
        {
            controls.text = "Esc - Pause \nA - Left Flipper \nL - Right Flipper \nLCtrl - Spawn Ball \nX - Destroy Ball";
        }
        else if (circuitCam.inCamera == true)
        {
            controls.text = "Left Click - Select";
        }
        else
        {
            controls.text = "Esc - Pause \nLeft Click - Select \nF - Pick Up / Interact \nE - Drop";
        }
    }
}
