using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventClick : MonoBehaviour, IPointerClickHandler
{
    public BreakerBoxPuzzle boxPuzzle;

    public void OnPointerClick(PointerEventData eventData)
    {
        boxPuzzle.currentTag = gameObject.tag;
    }
}
