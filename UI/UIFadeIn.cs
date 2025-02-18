using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine;

public class UIFadeIn : MonoBehaviour
{

    public Color fromColor = new Color(0f, 0, 0f, 1f);
    public Color targetColor = new Color(0f, 0f, 0f, 0f);
    Image im;
    float fadeTime;
    float startTime;
    
    // Start is called before the first frame update
    void Start()
    {
        im = GetComponent<Image>();

        im.color = fromColor;
        targetColor = new Color(0f, 0f, 0f, 0f);

        startTime = Time.time;
        fadeTime = 4f;
    }

    public void FadeIn(bool force = false)
    {
        if (force) DOTween.Clear();

        im = GetComponent<Image>();
        im.color = fromColor;

        startTime = Time.time;
        fadeTime = 4f;
        targetColor = new Color(0f, 0f, 0f, 0f);
    }

    public void FadeInTime(float time = 1f)
    {
        im = GetComponent<Image>();

        targetColor = fromColor;

        startTime = Time.time;
        fadeTime = time;
    }
    
    // Update is called once per frame
    void Update()
    {

        if (im == null) return;

        var color = im.color;

        float t = (Time.time - startTime) / fadeTime;
        color.r = Mathf.SmoothStep(color.r, targetColor.r, t);
        color.g = Mathf.SmoothStep(color.g, targetColor.g, t);
        color.b = Mathf.SmoothStep(color.b, targetColor.b, t);
        color.a = Mathf.SmoothStep(color.a, targetColor.a, t);

        im.color = color;

    }
}
