using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface Interactable
{
    public void Interact();
}

public class PinballPlayScript : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Ray r = new Ray (InteractorSource.position, InteractorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out Interactable interactObj))
                {
                    interactObj.Interact();
                }
            }
        }
    }
}
