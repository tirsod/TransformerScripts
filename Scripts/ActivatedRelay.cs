using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Fires a different event depending on whether this gameobject
// is activated OR deactivated in the hierarchy.

// Can be locked with "deactivateRightAfter" so it works only once.
public class ActivatedRelay : MonoBehaviour
{

    public bool deactivateRightAfter = true;
    public UnityEvent OnSetOffWhileActivated;
    public UnityEvent OnSetOffWhileDeactivated;
    public bool locked = true;
    
    public void SetOff()
    {
        if (locked) return;
        if (gameObject.activeSelf)
        {
            OnSetOffWhileActivated.Invoke();
            if (deactivateRightAfter)
            {
                locked = true;
            }
        }
        else
        {
            OnSetOffWhileDeactivated.Invoke();
        }
    }
    
}
