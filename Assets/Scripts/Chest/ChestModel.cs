using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestModel 
{
    public string Name { get; private set; }
    public Sprite Icon { get; private set; }
    public int MinCoins { get; private set; }
    public int MaxCoins { get; private set; }
    public int MinGems { get; private set; }
    public int MaxGems { get; private set; }
    public int UnlockCost { get; private set; }
    public float UnlockTime { get; private set; }


   public ChestModel(Chest_SO Chest)
    {
        Name = Chest.Name;
        Icon = Chest.Icon;
        MinCoins = Chest.MinCoins;
        MaxCoins = Chest.MaxCoins;
        MinGems = Chest.MinGems;
        MaxGems = Chest.MaxGems;
        UnlockTime = Chest.UnlockTime;
        UnlockCost = Chest.UnlockCost;
        
    }
}
