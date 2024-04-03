using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Chest
{
    public class ChestView : MonoBehaviour
    {
        public ChestController Controller;
        public Slot SlotReference;

        [SerializeField] private Sprite emptySlotSprite;
        [SerializeField] public Text ChestTimerText;
        [SerializeField] private Text chestSlotSprite;
        [SerializeField] private Text chestTypeText;
        [SerializeField] private Image coinSpirte;
        [SerializeField] private Text coinText;
        [SerializeField] private Image gemSpirte;
        [SerializeField] private Text gemText;

        [SerializeField] private Button chestButton;




    }
}