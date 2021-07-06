using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int encounterChance = 10;

    public void TriggerBattle()
    {
        Debug.Log("Encountered a wild pokemon");
    }

}
