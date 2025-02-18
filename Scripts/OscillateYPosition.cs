using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Creates a "vertical hovering" effect on the attached gameobject.
/// </summary>
public class OscillateYPosition : MonoBehaviour
{
    public float factor = 0.01f;
    public float power = 25f;
    private float myStart = 0f;

    private Transform t;
    private Vector3 startPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        myStart = Random.Range(-1f, 1f);
        t = transform;
        startPosition = t.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p = t.position;
        p.y = startPosition.y + myStart + Mathf.Sin(Time.timeSinceLevelLoad * factor) * power;
        t.position = p;
    }
}
