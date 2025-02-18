using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Adds a Vector3 (speed) to this gameobject's position over time.
/// </summary>
public class PositionTranslate : MonoBehaviour
{
    //public float speed = 10f;
    public Vector3 speed = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed*Time.deltaTime);
        //transform.Translate(0, speed*Time.deltaTime, 0);
    }
}
