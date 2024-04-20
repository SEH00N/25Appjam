using UnityEngine;

namespace Collisions
{
    public interface IDamageable
    {
        public void OnDamage(float damage, GameObject performer);
    }
}
