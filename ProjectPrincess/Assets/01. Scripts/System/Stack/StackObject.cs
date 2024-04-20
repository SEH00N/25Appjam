using System;
using UnityEngine;
using Utility;

namespace Stacks
{
    public class StackObject : MonoBehaviour
    {
        private BasicMovement movement = null;

        private StackObjectState state;
        public StackObjectState State => state;

        public event Action<StackObjectState> OnStateChangedEvent = null;
        
        private void Awake()
        {
            movement = GetComponent<BasicMovement>();
        }

        public void ChangeState(StackObjectState newState)
        {
            state = newState;
            OnStateChangedEvent?.Invoke(state);
            HandleStateChanged(state);
        }

        private void HandleStateChanged(StackObjectState state)
        {
            switch(state)
            {
                case StackObjectState.Queue:
                    movement.SetActive(true);
                    break;
            }
        }
    }
}
