using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class UIService : GenericMonoSingleton<UIService>
    { 
        [SerializeField]
        private TextMeshProUGUI Gems;
        [SerializeField]
        private TextMeshProUGUI Coins;
        [SerializeField]
        private GameObject slotsFullPanel;
        [SerializeField]
        private GameObject busyUnlockingPanel;
        [SerializeField]
        private GameObject unlockChestPanel;
        [SerializeField]
        private GameObject notEnoughResourcesPanel;
        [SerializeField]
        public GameObject rewardPopup;
        [SerializeField]
        public TextMeshProUGUI rewardReceivedText;

        public void UpdateGemsUI(int gems)
        {
            Gems.text = gems.ToString();
        }

        public void UpdateCoinsUI(int coins)
        {
            Coins.text = coins.ToString();
        }


    }
}