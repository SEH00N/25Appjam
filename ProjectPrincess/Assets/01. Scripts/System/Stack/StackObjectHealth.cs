using Collisions;
using UnityEngine;
using Utility;

namespace Stacks
{
    public class StackObjectHealth : MonoBehaviour, IDamageable
    {
        private BasicMovement movement = null;

        private void Awake()
        {
            movement = GetComponent<BasicMovement>();
        }

        public void OnDamage(float damage, GameObject performer)
        {
            movement.SetActive(false);
        }
    }
}
