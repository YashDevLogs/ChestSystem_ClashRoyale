using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Chest
{
    [CreateAssetMenu(fileName = "ChestConfigSO", menuName = "ScriptableObjects/Chests/ChestConfigurations")]
    public class ChestConfiguration : ScriptableObject
    {
        [Serializable]
        public class ChestConfigPair
        {
            public ChestType ChestType;
            public Chest_SO ChestSO;
        }

        public ChestConfigPair[] ChestConfigurationMap;

    }
}