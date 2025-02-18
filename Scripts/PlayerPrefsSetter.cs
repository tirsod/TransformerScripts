using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Kind of an interesting script.
/// I used this in my game to save flags like
/// "Level1Finished" from UnityEvents called from other triggers,
/// directly from the inspector.
/// 
/// (autoset) will set the PlayerPref value in the registry using
/// the Preference Type, the Name and the Value as soon as the
/// gameobject is turned on.
/// 
/// See also: ConditionalPlayerPrefs
/// </summary>
public class PlayerPrefsSetter : MonoBehaviour
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
    public bool autoset = false;

    void OnEnable()
    {
        if (autoset) SetPreference();
    }
    
    public void SetPreference()
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
        PlayerPrefs.SetInt(preferenceName, int.Parse(preferenceValue));
    }

    void CheckFloat()
    {
        PlayerPrefs.SetFloat(preferenceName, float.Parse(preferenceValue));
    }

    void CheckString()
    {
        PlayerPrefs.SetString(preferenceName, preferenceValue);
    }
}
