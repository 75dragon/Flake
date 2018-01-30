using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IDragHandler {

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("hello");
        Debug.Log(eventData.position.x);
        Debug.Log(eventData.position.y);
        Debug.Log(transform.position);
        transform.position = eventData.position;
    }
}
