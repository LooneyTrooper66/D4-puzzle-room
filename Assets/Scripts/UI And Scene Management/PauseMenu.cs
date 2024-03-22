using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused;
    public Button exitButton;
    public Image buttonImage;

    public PlayerMovement movementScr;
    public MouseMovement mouseScr;
    public BreakerBoxPuzzle breakerScr;
    public KeycodePuzzleRaycastScript keyScr;


    private void Start()
    {
        isPaused = false;
        exitButton.enabled = false;
        buttonImage.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
        {
            Cursor.lockState = CursorLockMode.Confined;
            exitButton.enabled = true;
            buttonImage.enabled = true;

            movementScr.enabled = false;
            mouseScr.enabled = false;
            breakerScr.enabled = false;
            keyScr.enabled = false;

            isPaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            exitButton.enabled = false;
            buttonImage.enabled = false;

            movementScr.enabled = true;
            mouseScr.enabled = true;
            breakerScr.enabled = true;
            keyScr.enabled = true;

            isPaused = false;
        }
    }
}
