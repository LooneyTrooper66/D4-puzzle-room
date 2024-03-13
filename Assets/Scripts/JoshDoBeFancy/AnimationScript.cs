using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public GameObject josh;
    private Transform joshStart;
    public Transform point1;
    public Transform point2;
    public float percentage;

    public float lerpedValue;
    public float duration = 3;

    public void Update()
    {
        //transform.position = Vector3.Lerp(point1.position, point2.position, percentage);
    }
}
