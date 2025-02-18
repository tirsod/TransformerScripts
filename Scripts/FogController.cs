using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Change the fog color when this object is enabled.
public class FogController : MonoBehaviour
{

    public bool setFogToThisColor = false;
    public Color fogColor;

    public void EnableFog()
    {
        RenderSettings.fog = true;
    }

    public void DisableFog()
    {
        RenderSettings.fog = false;
    }

    void Start()
    {
        if (setFogToThisColor) RenderSettings.fogColor = fogColor;
    }
    
}
