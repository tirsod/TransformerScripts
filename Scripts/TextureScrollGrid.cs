using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Similar to OffsetMaterial, but locks the grid offsets
/// to a grid. This is good for dot matrix screens or pixel art.
/// </summary>
public class TextureScrollGrid : MonoBehaviour
{

    private Material m;
    public float gridSize = 16f;
    public float time = 0.2f;
    private float timemax;
    public int xspeed = -1;
    public int yspeed = 0;

    void Start()
    {
        m = GetComponent<MeshRenderer>().sharedMaterial;
        Do();
    }

    void Do()
    {
        float offx = xspeed * (2/gridSize);
        float offy = yspeed * (2/gridSize);
        m.SetTextureOffset("_MainTex", new Vector2(m.mainTextureOffset.x+offx, m.mainTextureOffset.y+offy));
        Invoke("Do", time);
    }
    
}
