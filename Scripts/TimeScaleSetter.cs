using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Set the TimeScale with a function.
/// Could call this from the inspector using a UnityEvent.
/// Pauses, slow-mo, speed-ups, you know the drill.
/// </summary>
public class TimeScaleSetter : MonoBehaviour
{
    public void SetTimeScale(float time)
    {
        Time.timeScale = time;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }
    
}
