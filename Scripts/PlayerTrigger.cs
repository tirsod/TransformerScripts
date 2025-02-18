using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// It really just wants to know if the player is
/// inside of the trigger.
/// </summary>
public class PlayerTrigger : MonoBehaviour
{
    public bool IsPlayerOnTrigger = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            IsPlayerOnTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (IsPlayerOnTrigger)
        {
            if (other.CompareTag("Player"))
            {
                IsPlayerOnTrigger = false;
            }
        }
    }
}
