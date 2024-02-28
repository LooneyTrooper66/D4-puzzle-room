using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinColliderScript : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            Debug.Log("Win");
        }
    }
}
