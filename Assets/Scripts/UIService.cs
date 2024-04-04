using Assets.Scripts.Chest;
using System.Collections;
using TMPro;
using Unity.VisualScripting;
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

        public void ToggleSlotsFullPopup(bool setActive)
        {
            slotsFullPanel.SetActive(setActive);
        }

        public void ToggleIsBusyUnlockingPopup(bool setActive)
        {
            busyUnlockingPanel.SetActive(setActive);
        }

        public void ToggleUnlockChestPopup(bool setActive)
        {
            unlockChestPanel.SetActive(setActive);
            if (setActive == false)
            {
                // Debug.Log("selected controller reference got deleted.");
                ChestService.Instance.selectedController = null;
            }
        }

        public void ToggleInsufficientResourcesPopup(bool setActive)
        {
            notEnoughResourcesPanel.SetActive(setActive);
        }

        public void ClosePanel()
        {
            
        }

    }
}