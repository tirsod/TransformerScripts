using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A slow sinewave applied on the emission color.
// Absolutely could do this with a shader instead.
public class EmissiveSlow : MonoBehaviour
{
    
    private Material m;

    void Start()
    {
        m = GetComponent<MeshRenderer>().sharedMaterial;
    }


    void Update()
    {
        m.SetColor("_EmissionColor", new Color(1f, 1f, 1f, 1f) * (Mathf.Sin(Time.timeSinceLevelLoad)*0.75f+0.5f));
    }
}
