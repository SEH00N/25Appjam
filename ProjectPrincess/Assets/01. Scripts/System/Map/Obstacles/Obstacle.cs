using Collisions;
using UnityEngine;

namespace Maps.Obstacles
{
    public class Obstacle : MonoBehaviour, ICollidable
    {
        public void OnCollide(GameObject other)
        {
            if(other.TryGetComponent<IDamaeable>(out IDamaeable damageable))
            {
                damageable?.OnDamage(100, gameObject);
            }
        }
    }
}
