using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MyButton : Button
{
    private void Update()
    {
        if (IsPressed() == true)
        {
            onClick.Invoke();
        }
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        //base.OnPointerClick(eventData);
    }
}
