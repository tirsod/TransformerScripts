using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRandomFill : MonoBehaviour
{

    private Image im;

    // Start is called before the first frame update
    void Start()
    {
        im = GetComponent<Image>();
        im.fillAmount = Random.Range(0.0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        im.fillAmount += Random.Range(-0.05f, 0.05f);
    }
}
