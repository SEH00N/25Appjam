using UnityEngine;

namespace Collisions
{
    public interface IDamaeable
    {
        public void OnDamage(float damage, GameObject performer);
    }
}
