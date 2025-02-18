using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Hides the mouse after 5 seconds.
// Makes it visible again if you moved it.
public class MouseHider : MonoBehaviour
{
    private float lastCursorMoved;

    bool HasMouseMoved()
    {
        return (Input.GetAxis("Mouse X") != 0) || (Input.GetAxis("Mouse Y") != 0);
    }
    
    void Update()
    {
        lastCursorMoved += Time.deltaTime;
        if (lastCursorMoved > 5f)
        {
            Cursor.visible = false;
        }
        else
        {
            Cursor.visible = true;
        }

        if (HasMouseMoved()) lastCursorMoved = 0f;
    }
}
