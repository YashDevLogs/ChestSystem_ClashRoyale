using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Chest
{
    public class ChestView : MonoBehaviour
    {
        public ChestController ChestController;
        public Slot SlotReference;
        public SlotController slotController;

        [SerializeField] private Sprite emptySlotSprite;
        [SerializeField] public TextMeshProUGUI ChestTimerText;
        [SerializeField] private Image chestSlotSprite;
        [SerializeField] private TextMeshProUGUI chestTypeText;
        [SerializeField] private Image coinSprite;
        [SerializeField] private TextMeshProUGUI coinText;
        [SerializeField] private Image gemSprite;
        [SerializeField] private TextMeshProUGUI gemsText;

        [SerializeField] private Button chestButton;

        private ChestState currentChestState;

        public void SetControllerReference(ChestController chestController)
        {
            this.ChestController = chestController;
        }

        private void Start()
        {
            InitializeEmptyChestView();
        }


        public void InitializeEmptyChestView()
        {
            ChestTimerText.gameObject.SetActive(false);
            chestSlotSprite.sprite = emptySlotSprite;
            chestTypeText.gameObject.SetActive(false);
            coinSprite.gameObject.SetActive(false);
            coinText.gameObject.SetActive(false);
            gemSprite.gameObject.SetActive(false);
            gemsText.gameObject.SetActive(false);
            chestButton.enabled = false;
            currentChestState = ChestState.None;
        }

        public void InitialiseViewUIForLockedChest()
        {
            ChestTimerText.gameObject.SetActive(true);
            chestSlotSprite.sprite = ChestController.chestModel.ChestIcon;
            chestTypeText.gameObject.SetActive(true);
            chestTypeText.text = ChestController.chestModel.ChestName;
            coinSprite.gameObject.SetActive(true);
            coinText.gameObject.SetActive(true);
            coinText.text = ChestController.chestModel.UnlockCost.ToString();
            gemSprite.gameObject.SetActive(true);
            gemsText.gameObject.SetActive(true);
            gemsText.text = ChestController.GetGemCost().ToString();
            chestButton.enabled = true;
            currentChestState = ChestState.Locked;
        }

        public void InitialiseViewUIForUnlockingChest()
        {
            ChestTimerText.gameObject.SetActive(true);
            chestSlotSprite.sprite = ChestController.chestModel.ChestIcon;
            chestTypeText.gameObject.SetActive(true);
            chestTypeText.text = ChestController.chestModel.ChestName;
            coinSprite.gameObject.SetActive(false);
            coinText.gameObject.SetActive(false);
            gemSprite.gameObject.SetActive(false);
            gemsText.gameObject.SetActive(false);
            chestButton.enabled = false;
            currentChestState = ChestState.Unlocking;
        }

        public void InitialiseViewUIForUnlockedChest()
        {
            ChestTimerText.gameObject.SetActive(true);
            chestSlotSprite.sprite = ChestController.chestModel.ChestIcon;
            chestTypeText.gameObject.SetActive(true);
            chestTypeText.text = ChestController.chestModel.ChestName;
            coinSprite.gameObject.SetActive(false);
            coinText.gameObject.SetActive(false);
            gemSprite.gameObject.SetActive(false);
            gemsText.gameObject.SetActive(false);
            chestButton.enabled = true;
            currentChestState = ChestState.Unlocked;
        }

        public void EnteringUnlockingState()
        {
            slotController.IsUnlocking = true;
            InitialiseViewUIForUnlockingChest();
            ChestController.StartTimer();

        }

        public void OpenInstantly()
        {
            InitializeEmptyChestView();
            ReceiveChestRewards();
            ChestService.Instance.selectedController = ChestController;
            SlotReference.isEmpty = true;
            ChestService.Instance.ToggleRewardsPopup(true);
            SlotReference.chestController = null;

        }

        public void EnteringUnlockedState()
        {
            slotController.IsUnlocking = false;
            InitialiseViewUIForUnlockedChest();
            ChestTimerText.text = "OPEN!";
        }

        public void OpenChest()
        {
            InitializeEmptyChestView();
            ReceiveChestRewards();
            SlotReference.isEmpty = true;
            SlotReference.chestController = null;
        }

        public void ReceiveChestRewards()
        {
            ResourceService.Instance.AddCoins(ChestController.chestModel.CoinsReward);
            ResourceService.Instance.AddGems(ChestController.chestModel.GemsReward);
        }

        public void OnClickChestButton()
        {
            if (currentChestState == ChestState.Locked)
            {
                if (slotController.IsUnlocking)
                {
                    UIService.Instance.ToggleIsBusyUnlockingPopup(true);
                }
                else
                {
                    ChestService.Instance.selectedController = ChestController;
                    UIService.Instance.ToggleUnlockChestPopup(true);
                }
            }
            else if (currentChestState == ChestState.Unlocking)
            {
                /*

                1. Show a popup using UIHandler to UNLOCK Chest through gems(cost calculated by controller) instantly.
                2. If option chosen then call method EnteringUnlockedState() from the ChestView.

                 */
            }
            else if (currentChestState == ChestState.Unlocked)
            {
                ChestService.Instance.selectedController = ChestController;
                OpenChest();
                ChestService.Instance.ToggleRewardsPopup(true);

                /*

                1. Call a method OpenChest() from ChestView.

                 */
            }
        }

    }

  
}