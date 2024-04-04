using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Chest
{
    public class ChestController 
    {
        public ChestView chestView;
        public ChestModel chestModel;
        public float UnlockTimer;

        public ChestController(ChestModel chestModel, ChestView chestView) 
        {
            this.chestView = chestView;
            this.chestModel = chestModel;
            InitializeView();
            UnlockTimer = this.chestModel.UnlockTime;
        }

        public void InitializeView()
        {
            chestView.SetControllerReference(this);
            chestView.InitialiseViewUIForLockedChest();
        }

        public int GetGemCost()
        {
            UnlockTimer = chestModel.UnlockTime;
            return (int)Mathf.Ceil(UnlockTimer / 2);
        }

        public IEnumerator StartTimer()
        {
            while (UnlockTimer > 0)
            {
                chestView.ChestTimerText.text = UnlockTimer.ToString() + " M";
                yield return new WaitForSeconds(1f);
                UnlockTimer -= 1;
            }
            chestView.EnteringUnlockedState();
        }
    }

}
