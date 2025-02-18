using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Activate and deactivate a list of other gameobjects
/// in synchrony with this gameobject.
/// 
/// Like parent gameobjects disabling the children in the hierarchy
//  but without the parenting.
/// </summary>
public class MultiActivator : MonoBehaviour
{

    public GameObject[] handlesTheseGameobjects;

    public void EnableAll()
    {
        foreach (var obj in handlesTheseGameobjects)
        {
            obj.SetActive(true);
        }
    }

    public void DisableAll()
    {
        foreach (var obj in handlesTheseGameobjects)
        {
            obj.SetActive(false);
        }
    }

}
