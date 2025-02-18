using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Flicker the attached material's emission on collision
// with some other object. Ex: A lamp post flashing when
// a car crashes into it.
public class FlickerMatOnColl : MonoBehaviour
{

    private int working;
    public int frames = 30;
    private Material m;
    private Color initcolor;

    void Start()
    {
        m = GetComponent<MeshRenderer>().material;
        initcolor = m.color;
    }

    

    void OnCollisionEnter(Collision col)
    {
        working = frames;
    }
    
    
    void Update()
    {
        if (working > 0)
        {
            float v = Random.Range(-1f, 1f);
            m.SetColor("_EmissionColor", new Color(v, v, v, 1f));
            working--;
        }
        else
        {
            m.SetColor("_EmissionColor", initcolor);
        }
    }
}
