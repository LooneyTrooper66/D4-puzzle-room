using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ToolTipsScript : MonoBehaviour
{
    public TextMeshProUGUI ui;


    private void Start()
    {
        ui.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pickUp" ||  other.gameObject.name == "breaker box")
        {
            ui.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ui.enabled = false;
    }
}
