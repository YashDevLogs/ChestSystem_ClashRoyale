using Assets.Scripts.Chest;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class SlotController : MonoBehaviour
    {
        [SerializeField] Slot [] Slots;
        [SerializeField] private ChestConfiguration chestConfiguration;
        public bool IsUnlocking;

        private void Start()
        {
            IsUnlocking = false;
        }

        public void SpawnRandom()
        {
            int slot = GetEmptySlot();
            if(slot == -1)
            {
                UIService.Instance.ToggleSlotsFullPopup(true);
            }
            else
            {
                Slots[slot].SpawnRandomChest(chestConfiguration.ChestConfigurationMap[Random.Range(0, 4)].ChestSO);
            }
        }

        private int GetEmptySlot()
        {
            for (int i = 0; i < 4; i++)
            {
                if (Slots[i].isEmpty)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}