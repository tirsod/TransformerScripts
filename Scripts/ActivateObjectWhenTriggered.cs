using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Activates a GameObject when the attached trigger is entered.
public class ActivateObjectWhenTriggered : MonoBehaviour
{

    public GameObject objectToActivate;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            objectToActivate.SetActive(true);
            Destroy(gameObject);
        }
    }
    
}
