using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnScript : MonoBehaviour
{
    public GameObject ballPrefab;
    public static int loadIndex = 0;

    public CameraRaycastScript buttonCheck;


    public void Update()
    {
        if (buttonCheck.buttonOn == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                SpawnBall();
            }
        }
    }

    void SpawnBall()
    {
        if (loadIndex <= 0)
        {
            loadIndex = 0;
        }

        if (loadIndex == 0)
        {
            Instantiate(ballPrefab);
            loadIndex++;
        }
        else 
        {
            Debug.Log("nu uh");
        }
    }
}
