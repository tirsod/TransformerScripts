using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Fires a UnityEvent whenever this KeyCode is pressed.
/// Edit from the inspector.
/// </summary>
public class OnKeyPressEvent : MonoBehaviour
{
    public UnityEvent pressEvent;
    public KeyCode key;

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            pressEvent.Invoke();    
        }
    }
}
