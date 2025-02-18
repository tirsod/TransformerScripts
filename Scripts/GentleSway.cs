using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sofly rotate this transform's x and z euler angles.
// (Like a palm tree swaying in the wind) 
public class GentleSway : MonoBehaviour
{
    private Vector3 initRot;
    public float forceX = 0f;
    public float forceZ = 1f;

    // Start is called before the first frame update
    void Start()
    {
        initRot = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        float swayx = forceX*Mathf.Sin(Time.timeSinceLevelLoad);
        float swayz = forceZ*Mathf.Sin(Time.timeSinceLevelLoad);
        transform.eulerAngles = new Vector3(initRot.x+swayx, initRot.y, initRot.z+swayz);
    }
}
