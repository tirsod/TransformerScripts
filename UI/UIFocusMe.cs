﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIFocusMe : MonoBehaviour
{

    void Update()
    {
        if (EventSystem.current.currentSelectedGameObject == gameObject)
        {
            GetComponent<Button>().Select();
        }
    }
}
