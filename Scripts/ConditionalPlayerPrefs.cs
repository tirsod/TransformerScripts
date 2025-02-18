using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// See first: PlayerPrefsSetter
/// 
/// This script checks if a PlayerPref of type (PrefType) is equal
/// to the preferenceValue. If it's true, it fires an 
/// OnConditionMet event. If not, it will fire the opposite event.
/// 
/// Example, with the values:
/// preferenceType = string
/// preferenceName = "doorOpen"
/// preferenceValue = "open"
/// preferenceDefaultValue = "closed"
/// isOnEnable = true
/// 
/// This script would check if "doorOpen" equals "open",
/// if it's true, it would fire the event, which from the
/// inspector could be set to disable some gameobject that 
/// blocks the path. If this value hadn't been set before,
/// it would simply set it to "closed".
/// </summary>
public class ConditionalPlayerPrefs : MonoBehaviour
{
    public enum PrefType
    {
        Int = 0,
        Float = 1,
        String = 2
    }

    public PrefType preferenceType;
    public string preferenceName;
    public string preferenceValue;
    public string preferenceDefaultValue;
    
    public UnityEvent OnConditionMet;
    public UnityEvent OnConditionUnmet;

    public bool isOnEnable = false;
    
    void Start()
    {
        if (!isOnEnable) DoCheck();
    }

    private void OnEnable()
    {
        if (isOnEnable) DoCheck();
    }

    void DoCheck()
    {
        switch (preferenceType)
        {
            case PrefType.Int:
                CheckInt();
                break;
            case PrefType.Float:
                CheckFloat();
                break;
            case PrefType.String:
                CheckString();
                break;
        }
    }
    
    void CheckInt()
    {
        if (PlayerPrefs.GetInt(preferenceName, int.Parse(preferenceDefaultValue) ) == int.Parse(preferenceValue) )
        {
            OnConditionMet.Invoke();
        }
        else
        {
            OnConditionUnmet.Invoke();
        }
    }

    void CheckFloat()
    {
        if (PlayerPrefs.GetFloat(preferenceName, float.Parse(preferenceDefaultValue) ) == float.Parse(preferenceValue) )
        {
            OnConditionMet.Invoke();
        }
        else
        {
            OnConditionUnmet.Invoke();
        }
    }

    void CheckString()
    {
        if (PlayerPrefs.GetString(preferenceName, preferenceDefaultValue ) == preferenceValue )
        {
            OnConditionMet.Invoke();
        }
        else
        {
            OnConditionUnmet.Invoke();
        }
    }

}
