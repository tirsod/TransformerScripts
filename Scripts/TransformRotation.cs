using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script works just like PositionTranslate, but 
/// instead of moving the transform, it rotates it.
/// </summary>
public class TransformRotation : MonoBehaviour
{
    public Vector3 Speed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Speed*Time.deltaTime, Space.Self);
    }
}
