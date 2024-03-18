using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneCameraScript : MonoBehaviour
{
    public Canvas gameOver;
    public Canvas cutscene;

    private float timeLeft = 10;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        gameOver.enabled = false;
        cutscene.enabled = true;
    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else if (timeLeft <= 0)
        {
            Cursor.lockState = CursorLockMode.Confined;

            timeLeft = 0;
            gameOver.enabled = true;
            cutscene.enabled = false;
        }
    }
}
