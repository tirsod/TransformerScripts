using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Invokes a UnityEvent OnEnabled when the object is Enabled in the hierarchy.
// Same for when it is Deactivated: OnDisabled.
public class ActivationEvents : MonoBehaviour
{
    public UnityEvent OnEnabled;
    public UnityEvent OnDisabled;

    public virtual void OnEnable()
    {
        OnEnabled.Invoke();
    }
    public virtual void OnDisable()
    {
        OnDisabled.Invoke();
    }
}
