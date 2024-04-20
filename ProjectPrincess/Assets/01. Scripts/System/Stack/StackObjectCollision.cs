using Collisions;
using Players;
using UnityEngine;
using UnityEngine.Events;

namespace Stacks
{
    public class StackObjectCollision : MonoBehaviour, ICollidable
    {
<<<<<<< Updated upstream
        [SerializeField] LayerMask castingLayer = 0;
        [SerializeField] UnityEvent onCollisionEvent = null;
=======
        [SerializeField] GameObject heartParticle;

        [SerializeField] LayerMask playerLayer = 0;
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
            stacker.AddStackObject(stackObject);
            onCollisionEvent?.Invoke();
=======
            if(other.TryGetComponent<Player>(out Player player))
            {
                Instantiate(heartParticle, transform.position, Quaternion.identity);
                player.AddStackObject(stackObject);
            }
        }

        public void HandleStackObjectChanged(StackObjectState state)
        {
            if(state == StackObjectState.Queue)
            {
                col.isTrigger = false;
                rb.useGravity = true;
            }
>>>>>>> Stashed changes
        }
    }
}
