using Collisions;
using UnityEngine;

namespace Maps.Obstacles
{
    public class Obstacle : MonoBehaviour
    {
        [SerializeField] LayerMask castingLayer = 1 << 7 | 1 << 8;

        private void OnCollisionEnter(Collision other)
        {
            int otherLayer = 1 << other.gameObject.layer;
            if((otherLayer & castingLayer) == 0)
                return;

            if(other.gameObject.TryGetComponent<IDamageable>(out IDamageable damageable))
                damageable?.OnDamage(1f, gameObject);
        }
    }
}
