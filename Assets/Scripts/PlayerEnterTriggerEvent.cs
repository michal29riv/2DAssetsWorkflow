﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerEnterTriggerEvent : MonoBehaviour
{
    public UnityEvent activatedEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            activatedEvent.Invoke();
        }
    }
}
