using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFrontScript : MonoBehaviour
{
    public GameObject zombieFront;
    public GameObject zombieBack;
    public GameObject zombieBase;

    public float targetTime = 5.0f;
    public float rotateTime = 1.00095f;
    public float rotateSpeed = 180f;

    public TriggerDetectionScript pinballScr;
    

    private void Update()
    {
        if (pinballScr.playingPinball == true)
        {
            targetTime -= Time.deltaTime;

            if (targetTime <= 0.0f)
            {
                targetTime = 0.0f;
                RotateToBack();
            }
        }
    }

    void RotateToBack()
    {
        rotateTime -= Time.deltaTime;

        if (rotateTime >= 0.0f)
        {
            zombieBase.transform.Rotate(0, 0, 1f * rotateSpeed * Time.deltaTime);
        }
        else if (rotateTime < 0.0f)
        {
            targetTime = 5.0f;
            rotateTime = 1.00095f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            Destroy(zombieFront);
            Destroy(zombieBack);
            Destroy(zombieBase);
        }
    }
}
