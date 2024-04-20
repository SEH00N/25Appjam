using UnityEngine;

namespace Collisions
{
    public interface ICollidable
    {
        public void OnCollide(GameObject other);
    }
}
