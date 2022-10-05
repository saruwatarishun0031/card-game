using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestCardMove : MonoBehaviour, IDragHandler,IBeginDragHandler,IEndDragHandler
{
    public Transform defaultParent;
    /// <summary>
    /// カードを持った時
    /// </summary>
    /// <param name="eventData"></param>
    public void OnBeginDrag(PointerEventData eventData)
    {
        defaultParent = transform.parent;
        transform.SetParent(defaultParent.parent, false);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    /// <summary>
    /// カードを持ってる最中
    /// </summary>
    /// <param name="eventData"></param>
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    /// <summary>
    /// カードを置いた時
    /// </summary>
    /// <param name="eventData"></param>
    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(defaultParent, false);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}

