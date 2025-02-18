using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Replace an UI.Image's sprite with one in the sequence
/// from the array sprites. You can also set the animation's
/// framerate.
/// </summary>
public class SpriteSequence : MonoBehaviour
{
    public Sprite[] sprites;
    public int framesPerSecond;
    public Image image;

    private int frame;
    
    void Start()
    {
        InvokeRepeating(nameof(NextFrame), 0f, 1f/framesPerSecond);
    }

    void NextFrame()
    {
        image.sprite = sprites[frame];
        frame++;
        if (frame > sprites.Length-1) frame = 0;
    }
    
}
