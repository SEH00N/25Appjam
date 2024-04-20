using Collisions;
using Core;
using UnityEngine;

namespace Players
{
    public class PlayerHealth : MonoBehaviour, IDamaeable
    {
        public void OnDamage(float damage, GameObject performer)
        {
            GameManager.Instance.Cycle.FinishGame();
            Destroy(gameObject);
        }
    }
}
