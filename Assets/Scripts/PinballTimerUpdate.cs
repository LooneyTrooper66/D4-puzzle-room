using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PinballTimerUpdate : MonoBehaviour
{
    public Text controls;

    public TriggerDetectionScript pinball;
    public PauseMenu paused;


    private void Update()
    {
        if (paused.isPaused == true)
        {
            controls.text = "Esc - Unpause";
        }

        if (pinball.playingPinball == true && paused.isPaused == false)
        {
            controls.text = "Esc - Pause \nA - Left Flipper \nL - Right Flipper \nLCtrl - Spawn Ball \nX - Destroy Ball";
        }
        else if (pinball.playingPinball == true && paused.isPaused == true)
        {
            controls.text = "Esc - Unpause";
        }
    }
}
