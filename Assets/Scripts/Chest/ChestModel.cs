using UnityEngine;

public class ChestModel 
{
    public string ChestName { get; private set; }
    public Sprite ChestIcon { get; private set; }
    public int CoinsReward{ get; private set; }
    public int GemsReward { get; private set; }
    public int UnlockCost { get; private set; }
    public float UnlockTime { get; private set; }


   public ChestModel(Chest_SO Chest)
    {
        ChestName = Chest.Name;
        ChestIcon = Chest.Icon;
        CoinsReward = Random.Range(Chest.MinCoins, Chest.MaxCoins + 1);
        GemsReward = Random.Range(Chest.MinGems, Chest.MaxGems + 1);
        UnlockTime = Chest.UnlockTime;
        UnlockCost = Chest.UnlockCost;
    }
}
