using System;
using Extensions;
using UnityEngine;
using Utility;

namespace Stacks
{
    public class StackObject : MonoBehaviour
    {
        [SerializeField] GameObject[] skins = null;
        [SerializeField] Transform skinContainer = null;
        [SerializeField] GameObject smokeParticle;

        private BasicMovement movement = null;

        private StackObjectState state;
        public StackObjectState State => state;

        public event Action<StackObjectState> OnStateChangedEvent = null;
        
        private void Awake()
        {
            movement = GetComponent<BasicMovement>();
        }

        private void Start()
        {
            GameObject instance = Instantiate(skins.PickRandom(), skinContainer);
            instance.transform.localPosition = Vector3.zero;
            instance.transform.localRotation = Quaternion.identity;
        }

        public void ChangeState(StackObjectState newState)
        {
            state = newState;
            OnStateChangedEvent?.Invoke(state);
            HandleStateChanged(state);

            Instantiate(smokeParticle, transform.position, Quaternion.identity);

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
