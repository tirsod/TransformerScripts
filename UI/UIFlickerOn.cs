using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFlickerOn : MonoBehaviour
{
    private Image _image;
    private Text _text;
    private bool imageMode;
    private bool flickeringOn = false;
    private float flickerVal;
    
    void Start()
    {
        if (GetComponent<Image>() != null)
        {
            _image = GetComponent<Image>();
            _image.enabled = false;
            imageMode = true;
        }
        else
        {
            _text = GetComponent<Text>();
            _text.enabled = false;
        }
        Invoke(nameof(FlickerStart), 1f);
        Invoke(nameof(FlickerEnd), 2f);
    }

    void FlickerStart()
    {
        flickeringOn = true;
    }
    void FlickerEnd()
    {
        if (imageMode) _image.enabled = true;
        else _text.enabled = true;
        flickeringOn = false;
    }

    void FlickerImage()
    {
        if (Random.value < 0.5f) _image.enabled = !_image.enabled;
    }
    void FlickerText()
    {
        if (Random.value < 0.5f) _text.enabled = !_text.enabled;
    }
    
    void Update()
    {
        if (!flickeringOn) return;

        if (imageMode) FlickerImage();
        else FlickerText();

        if (flickerVal >= 1f)
        {
            flickeringOn = false;
        }
    }
    
}
