using Assets.Scripts.Chest;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Slot : MonoBehaviour
    {

        [SerializeField] ChestView chestView;
        public bool isEmpty;
        [HideInInspector]
        public ChestController chestController;


        private void Start()
        {
            isEmpty = true;
        }

        public void SpawnRandomChest(Chest_SO randomChestSO)
        {
            chestController = ChestService.Instance.GetChest(randomChestSO, chestView);
            isEmpty = false;
        }

        public void SetSlotReference()
        {
            chestView.SlotReference = this;
        }
    }
}