using Collisions;
using Players;
using UnityEngine;
using UnityEngine.Events;

namespace Stacks
{
    public class StackObjectCollision : MonoBehaviour, ICollidable
    {
        [SerializeField] UnityEvent onCollisionEvent = null;
        private StackObject stackObject = null;

        private void Awake()
        {
            stackObject = GetComponent<StackObject>();
        }

        public void OnCollide(GameObject other)
        {
            if(other.TryGetComponent<PlayerStacker>(out PlayerStacker stacker) == false)
                return;

            stacker.AddStackObject(stackObject);
            onCollisionEvent?.Invoke();
        }
    }
}
