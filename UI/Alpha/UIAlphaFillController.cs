using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UIAlphaFillController : MonoBehaviour
{

    public Image image;
    public Text text;
    
    void Start()
    {
        image = GetComponent<Image>();
        text = GetComponent<Text>();
    }

    public void StartAtZero()
    {
        if (image != null) image.fillAmount = 0f;
    }

    public void StartAtOne()
    {
        if (image != null) image.fillAmount = 1f;
    }
    
    public void FillToOne(float duration)
    {
        if (image != null) image.DOFillAmount(1f, duration);
    }
    public void AlphaToOne(float duration)
    {
        if (text != null) text.DOColor(Color.white, duration);
        else if (image != null) image.DOColor(Color.white, duration);
    }
    public void FillToZero(float duration)
    {
        if (image != null) image.DOFillAmount(0f, duration);
    }
    public void AlphaToZero(float duration)
    {
        if (text != null) text.DOColor(Color.clear, duration);
        else if (image != null) image.DOColor(Color.clear, duration);
    }
    
    
}
