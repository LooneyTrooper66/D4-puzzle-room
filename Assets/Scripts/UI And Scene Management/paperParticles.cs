using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paperParticles : MonoBehaviour
{
    public DoubleDoorsScript doors;
    public PickUpScript pickUp;

    public ParticleSystem paperPs;


    private void Start()
    {
        doors.GetComponent<DoubleDoorsScript>();
        pickUp.GetComponent<PickUpScript>();
    }

    private void Update()
    {
        if (doors.woodPlaced == true && pickUp.paperUp == false && !paperPs.isPlaying)
        {
            paperPs.Play();
        }
        else if (doors.woodPlaced == true && pickUp.paperUp == true && paperPs.isPlaying)
        {
            paperPs.Stop();
            paperPs.Clear();
        }
    }
}
