using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public Vector3 startPos;

    virtual public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }

    virtual public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition;
    }

    virtual public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
    }

    public void setDraggableEnable(bool enable)
    {
        this.enabled = enable;
    }
}
