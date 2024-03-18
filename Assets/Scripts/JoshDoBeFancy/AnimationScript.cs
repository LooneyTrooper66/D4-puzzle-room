using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Transform josh;
    public Transform point1;
    public Transform point2;
    public Transform point3;

    public Animator joshAnim;
    private bool moving;

    private float speed = 0.9f;
    private float startTime;
    private float startTime2;
    private float journeyLength;
    private float journeyLength2;


    private void Start()
    {
        moving = true;
        startTime = Time.time;
        startTime2 = Time.time;

        journeyLength = Vector3.Distance(point1.position, point2.position);
        journeyLength2 = Vector3.Distance(point2.position, point3.position);
    }

    public void Update()
    {
        if (moving == true)
        {
            if (josh.position.z < -2.1f)
            {
                float distCovered = (Time.time - startTime) * speed;
                float fractionOfJourney = distCovered / journeyLength;
                transform.position = Vector3.Lerp(point1.position, point2.position, fractionOfJourney);

                startTime2 = Time.time;
            }
            else if (josh.position.z >= -2.15f && josh.position.z < 8.1f)
            {
                float distCovered2 = (Time.time - startTime2) * speed;
                float fractionOfJourney2 = distCovered2 / journeyLength2;
                transform.position = Vector3.Lerp(point2.position, point3.position, fractionOfJourney2);

                if (josh.position.z >= 8.05f)
                {
                    josh.position = point1.position;
                    joshAnim.SetBool("atP3", true);
                    moving = false;
                }
            }
        }
    }

}
