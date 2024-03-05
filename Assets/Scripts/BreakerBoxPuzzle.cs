using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class BreakerBoxPuzzle : MonoBehaviour
{
    public GameObject blueWire;
    public GameObject pinkWire;
    public GameObject whiteWire;

    public bool blueOn;
    public bool pinkOn;
    public bool whiteOn;
    public bool wiresConnected;

    public string currentTag;

    public string current;
    public string last;

    private void Start()
    {
        current = null;
        last = null;

        blueWire.SetActive(false);
        whiteWire.SetActive(false);
        pinkWire.SetActive(false);

        blueOn = false;
        pinkOn = false;
        whiteOn = false;

        wiresConnected = false;
    }

    public void Update()
    {
        last = current;
        current = currentTag;

        if (last == "Blue1" && current == "Blue2" || last == "Blue2" && current == "Blue1")
        {
            blueWire.SetActive(true);
            blueOn = true;
        }
        else if (last == "Pink1" && current == "Pink2" || last == "Pink2" && current == "Pink1")
        {
            pinkWire.SetActive(true);
            pinkOn = true;
        }
        else if (last == "White1" && current == "White2" || last == "White2" && current == "White")
        {
            whiteWire.SetActive(true);
            whiteOn = true;
        }

        if (blueOn == true && pinkOn == true && whiteOn == true)
        {
            wiresConnected = true;
        }
    }
}
