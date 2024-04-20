using Collisions;
using UnityEngine;

namespace Players
{
    public class PlayerCollision : MonoBehaviour
    {
        [SerializeField] LayerMask castingLayer = 0;

        private void OnTriggerEnter(Collider other)
        {
            int otherLayer = 1 << other.gameObject.layer;
            if((castingLayer & otherLayer) == 0)
                return;

            if(other.transform.TryGetComponent<ICollidable>(out ICollidable collidable) == false)
                return;

            collidable?.OnCollide(gameObject);
        }
    }
}
