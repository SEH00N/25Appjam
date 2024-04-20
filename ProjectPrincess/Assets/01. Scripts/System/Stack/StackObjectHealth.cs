using Collisions;
using UnityEngine;
using UnityEngine.Events;

namespace Stacks
{
    public class StackObjectHealth : MonoBehaviour, IDamaeable
    {        
        [SerializeField] UnityEvent onPlayerDeadEvent = null;

        public void OnDamage(float damage, GameObject performer)
        {
            onPlayerDeadEvent?.Invoke();
            Destroy(gameObject);
        }
    }
}
