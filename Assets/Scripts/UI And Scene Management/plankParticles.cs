using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plankParticles : MonoBehaviour
{
    public BreakerBoxPuzzle breaker;
    public GameObject plankSy;
    public ParticleSystem plankPs;


    private void Start()
    {
        breaker.GetComponent<PickUpScript>();
        plankPs.GetComponentInChildren<ParticleSystem>();
    }

    private void Update()
    {
        if (breaker.wiresConnected == true && !plankPs.isPlaying)
        {
            plankPs.Play();
        }
        else if (plankPs.isPlaying && this.gameObject.transform.root.gameObject.name == "bean")
        {
            plankSy.SetActive(false);
        }
    }
}
