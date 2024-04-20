using Collisions;
using Players;
using UnityEngine;
using UnityEngine.Events;

namespace Stacks
{
    public class StackObjectCollision : MonoBehaviour, ICollidable
    {
        [SerializeField] LayerMask castingLayer = 0;
        [SerializeField] UnityEvent onCollisionEvent = null;
        private StackObject stackObject = null;

        private void OnTriggerEnter(Collider other)
        {
            int otherLayer = 1 << other.gameObject.layer;
            if((castingLayer & otherLayer) == 0)
                return;

            if(other.transform.TryGetComponent<ICollidable>(out ICollidable collidable) == false)
                return;

            collidable?.OnCollide(gameObject);
        }

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
