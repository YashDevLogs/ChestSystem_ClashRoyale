using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Scripts.Chest
{
    public class ChestService : GenericMonoSingleton<ChestService>
    {
        public ChestController selectedController;

        public ChestController GetChest(Chest_SO randomChestSO, ChestView chestView)
        {
            ChestModel chestModel = new ChestModel(randomChestSO);
            ChestController chestController = new ChestController(chestModel, chestView);
            return chestController;

        }


        public void OnClickStartTimerWithCoins()
        {
            if (ResourceService.Instance.Coins < selectedController.chestModel.UnlockCost)
            {
                UIService.Instance.ToggleUnlockChestPopup(false);
                UIService.Instance.ToggleInsufficientResourcesPopup(true);
            }
            else
            {
                ResourceService.Instance.RemoveCoins(selectedController.chestModel.UnlockCost);
                selectedController.chestView.EnteringUnlockingState();
                UIService.Instance.ToggleUnlockChestPopup(false);
            }
        }

        public void OnClickOpenInstantlyWithGems()
        {
            if (ResourceService.Instance.Gems < selectedController.GetGemCost())
            {
                UIService.Instance.ToggleUnlockChestPopup(false);
                UIService.Instance.ToggleInsufficientResourcesPopup(true);
            }
            else
            {
                ResourceService.Instance.RemoveGems(selectedController.GetGemCost());
                selectedController.chestView.OpenInstantly();
                UIService.Instance.ToggleUnlockChestPopup(false);
            }
        }

        public void ToggleRewardsPopup(bool setActive)
        {
            if (!setActive)
            {
                selectedController = null;
            }
            else
            {
                UIService.Instance.rewardReceivedText.text
                    = "You received " + selectedController.chestModel.CoinsReward + " coins and " + selectedController.chestModel.GemsReward + " gems.";
            }
            UIService.Instance.rewardPopup.SetActive(setActive);
        }

    }
}