using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIEventListener : MonoBehaviour, IPointerClickHandler
{
    public delegate void PointerEventHandle(GameObject sender, PointerEventData eventData);

    public event PointerEventHandle onButtonClick;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (onButtonClick != null) onButtonClick(gameObject, eventData);
    }
}
