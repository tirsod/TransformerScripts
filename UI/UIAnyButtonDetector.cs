using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// This one's for that "press any button" screen in your game.
/// </summary>
public class UIAnyButtonDetector : MonoBehaviour
{

    public UnityEvent OnAnyButtonPressed;
    private bool isPressed;
    
    void Update()
    {
        if (Input.anyKeyDown)
        {
            OnAnyButtonPressed.Invoke();
        }
    }
}
