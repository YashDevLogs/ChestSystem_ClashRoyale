using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Chest
{
     class ChestStatePattern 
    {
        virtual public ChestStatePattern ReturnState()
        {
            return this;
        }


        class LockedState : ChestStatePattern 
        {
            ChestState State = ChestState.Locked;
            override public ChestStatePattern ReturnState()
            {
                return this;
            }
        }

        class UnlockingState : ChestStatePattern
        {
            override public ChestStatePattern ReturnState()
            {
                return this;
            }
        }
    }
}