using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Offsets the Main Texture's UVs over time on the attached MeshRenderer.
/// </summary>
public class OffsetMaterial : MonoBehaviour
{
    private Material m;

    public float xspeed = 0.001f;
    public float yspeed = 0.001f;
    
    private float rollx;
    private float rolly;

    public bool isOnSecondaryMap;

    public bool isOnShared = true;
    
    // Start is called before the first frame update
    void Start()
    {
        if (!isOnShared)
        {
            m = GetComponent<MeshRenderer>().material;
            return;
        }
        m = GetComponent<MeshRenderer>().sharedMaterial;
        if (m == null)
        {
            Debug.LogError("No MeshRenderer material found on gameobject "+gameObject.name);
            this.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        rollx += Time.deltaTime * xspeed;
        rolly += Time.deltaTime * yspeed;
        string target = "_MainTex";
        if (isOnSecondaryMap) target = "_DetailAlbedoMap";
        m.SetTextureOffset(target, new Vector2(rollx, rolly));
    }
}
