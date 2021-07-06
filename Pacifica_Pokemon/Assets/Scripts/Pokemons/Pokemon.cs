using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{

    PokemonBase mB;
    int level;

    public Pokemon(PokemonBase pBase, int pLevel)
    {
        mB = pBase;
        level = pLevel;
    }

    public int MaxHP
    {
        get { return Mathf.FloorToInt((mB.MaxHP * level) / 100f) + 10; }
    }
    public int Attack
    {
        get { return Mathf.FloorToInt((mB.Attack * level) / 100f) + 5; }
    }

    public int Defense
    {
        get { return Mathf.FloorToInt((mB.Defense * level) / 100f) + 5; }
    }

    public int SPAttack
    {
        get { return Mathf.FloorToInt((mB.SPAttack * level) / 100f) + 5; }
    }

    public int SPDefense
    {
        get { return Mathf.FloorToInt((mB.SPDefense * level) / 100f) + 5; }
    }

    public int Speed
    {
        get { return Mathf.FloorToInt((mB.Speed * level) / 100f) + 5; }
    }
}
