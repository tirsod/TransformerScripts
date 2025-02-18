using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Finds an attached AudioSource and changes its pitch to a random
/// value between min and max
/// </summary>
public class RandomizeAudioSourcePitch : MonoBehaviour
{

    public float min = 0.9f;
    public float max = 1.2f;

    void Start()
    {
        GetComponent<AudioSource>().pitch = Random.Range(min, max);
    }

}
