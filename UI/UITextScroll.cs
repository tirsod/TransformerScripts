using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextScroll : MonoBehaviour
{

    public RectTransform rect;

    public Vector3 initpos;
    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
        rect.position = new Vector3(rect.position.x + 50, rect.position.y, rect.position.z);
        initpos = rect.position;
    }

    public void ResetPosition()
    {
        rect.position = initpos;
    }
    
    // Update is called once per frame
    void Update()
    {
        rect.position = new Vector3(rect.position.x - Time.deltaTime*50, rect.position.y, rect.position.z);
    }
}
