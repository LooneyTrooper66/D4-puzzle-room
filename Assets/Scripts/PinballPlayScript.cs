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






    /*[SerializeField] private Transform InteractionPoint;
    [SerializeField] private float InteractionRadius = 0.5f;
    [SerializeField] private LayerMask InteractionMask;

    private readonly Collider[] Colliders = new Collider[3];
    [SerializeField] private int NumFound;


    private void Update()
    {
        NumFound = Physics.OverlapSphereNonAlloc(InteractionPoint.position, InteractionRadius, Colliders, InteractionMask);
    }*/
}
