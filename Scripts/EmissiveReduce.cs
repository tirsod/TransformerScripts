using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Lower the attached material's emission color
// Plus a function to reset it to a set intensity
public class EmissiveReduce : MonoBehaviour
{
    
    private Material m;
    public float reduce = 0.8f;
    
    void Start()
    {
        m = GetComponent<MeshRenderer>().sharedMaterial;
    }


    public void MaxIntensity(float intensity = 3f)
    {
        m.SetColor("_EmissionColor",  new Color(1f, 1f, 1f, 1f)*intensity);
    }
    
    void Update()
    {
        Color c = m.GetColor("_EmissionColor");
        Color newc = c;
        newc.r -= 5f*Time.deltaTime;
        newc.g -= 5f*Time.deltaTime;
        newc.b -= 5f*Time.deltaTime;
        m.SetColor("_EmissionColor",  newc);
    }
}
