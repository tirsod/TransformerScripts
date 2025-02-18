using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIShake : MonoBehaviour
{
    private RectTransform rect;

    private Vector3 rectinit;
    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
        rectinit = rect.anchoredPosition;
    }

    // Update is called once per frame
    void Update()
    {
        rect.anchoredPosition = new Vector3(Random.Range(-15, 15), 0, 0) + rectinit;
    }
}
