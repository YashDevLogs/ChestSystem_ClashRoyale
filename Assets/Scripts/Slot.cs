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


    }
}