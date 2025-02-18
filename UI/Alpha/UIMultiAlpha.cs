using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UIMultiAlpha : MonoBehaviour
{

    public void Queue(float delay)
    {
        Invoke(nameof(MultiClear), delay);
    }
    
    public void MultiClear()
    {
        float time = 1f;
        Text[] texts = GetComponentsInChildren<Text>();
        Image[] images = GetComponentsInChildren<Image>();

        foreach (var t in texts)
        {
            t.DOColor(Color.clear, time);
        }
        foreach (var i in images)
        {
            i.DOColor(Color.clear, time);
        }
    }
}
