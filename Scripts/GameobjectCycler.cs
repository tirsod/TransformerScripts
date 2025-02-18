using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Enables the next gameobject in the list.
/// Think of it as a sequence that you can call whenever
/// something happens in the game.
/// 
/// Example: Everytime you score a goal, EnableNext() is called
/// Element #1 is a cheer sound effect.
/// Element #2 is the cheers, Plus some confetti.
/// Element #3 is fireworks,
/// then Element #4 could be all together plus a trophy.
/// 
/// So, you have to score 4 goals for the trophy to show up. 
/// </summary>
public class GameobjectCycler : MonoBehaviour
{
    public GameObject[] elements;
    public int element = 0;

    public void EnableNext()
    {
        if (element < elements.Length-1)
        {
            element += 1;
            elements[element].SetActive(true);
        }
    }

}
