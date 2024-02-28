using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public BallSpawnScript ballSpawn;


    private void Start()
    {
        ballSpawn.GetComponent<BallSpawnScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Destroy(this.gameObject);
            BallSpawnScript.loadIndex = BallSpawnScript.loadIndex - 1;
        }
    }
}
