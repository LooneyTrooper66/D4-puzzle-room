using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject playerObject;
    private Camera playerCamera;


    private void Start()
    {
        playerCamera = playerObject.GetComponent<Camera>();
        playerObject.SetActive(true);
    }
}
