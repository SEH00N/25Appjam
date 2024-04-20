using System;
using Collisions;
using UnityEngine;
using Utility;

namespace Stacks
{
    public class StackObjectHealth : MonoBehaviour, IDamageable
    {
        private BasicMovement movement = null;
        private StackObject stackObject = null;

        private bool active = false;

        private void Awake()
        {
            movement = GetComponent<BasicMovement>();
            stackObject = GetComponent<StackObject>();

            stackObject.OnStateChangedEvent += HandleStateChanged;
        }

        private void HandleStateChanged(StackObjectState state)
        {
            active = state == StackObjectState.Stack;
        }

        public void OnDamage(float damage, GameObject performer)
        {
            if(active == false)
                return;

            Debug.Log("asd");
            movement.SetActive(false);
            Destroy(gameObject);
        }
    }
}
