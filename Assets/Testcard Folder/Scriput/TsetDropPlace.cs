using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TsetDropPlace : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        TestCardMove card = eventData.pointerDrag.GetComponent<TestCardMove>();
        if (card != null)
        {
            card.defaultParent = this.transform;
        }
    }
}
