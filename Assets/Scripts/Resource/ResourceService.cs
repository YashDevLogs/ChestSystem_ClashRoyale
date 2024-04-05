using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class ResourceService : GenericMonoSingleton<ResourceService>
    {
        public int Coins;
        public int Gems;

        private void Start()
        {
            Gems = 100;
            Coins = 300;
            UIService.Instance.UpdateGemsUI(Gems);
            UIService.Instance.UpdateCoinsUI(Coins);
        }

        public void AddGems(int Value)
        {
            Gems += Value;
            UIService.Instance.UpdateGemsUI(Gems);
        }

        public void RemoveGems(int Value) 
        {
            Gems -= Value;
            UIService.Instance.UpdateGemsUI(Gems);
        }

        public void AddCoins(int Value)
        {
            Coins += Value;
            UIService.Instance.UpdateCoinsUI(Coins);
        }
        public void RemoveCoins(int Value)
        {
            Coins -= Value;
            UIService.Instance.UpdateCoinsUI(Coins); 
        } 
    }
}