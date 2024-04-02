using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Chest_SO", menuName = "ScriptableObject/Chest_SO") ]
public class Chest_SO : ScriptableObject
{
    public string Name;
    public Sprite Icon;
    public int MinCoins;
    public int MaxCoins;
    public int MinGems;
    public int MaxGems;
    public float UnlockTime;
    public int UnlockCost;
}
