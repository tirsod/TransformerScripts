using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// <summary>
/// A light flicker effect. 
/// Uses the DoTween library to interpolate between the
/// random intensities. (Sorry! DoTween is awesome though. Check it out.)
/// </summary>
public class SpookyLight : MonoBehaviour
{
    private float initRange;
    public float addedRange = 0.1f;
    public float minColor;
    public float maxColor;
    
    private Color initColor;
    
    private Light l;

    public void SetMaxColor(float f)
    {
        maxColor = f;
    }
    
    void Start()
    {
        l = GetComponent<Light>();
        initRange = l.range;
        initColor = l.color;
    }

    // Update is called once per frame
    void Update()
    {
        l.DOColor(initColor * Random.Range(minColor, maxColor), 1f);
    }
}
