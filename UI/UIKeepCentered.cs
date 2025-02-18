using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIKeepCentered : MonoBehaviour
{
    private RectTransform myRectTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        myRectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = myRectTransform.anchoredPosition;
        pos.x = Mathf.Lerp(pos.x, 0f, 0.1f);
        myRectTransform.anchoredPosition = pos;
    }
}
