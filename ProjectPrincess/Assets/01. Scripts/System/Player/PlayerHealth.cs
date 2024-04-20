using Collisions;
using Core;
using UnityEngine;
using UnityEngine.Events;

namespace Players
{
    public class PlayerHealth : MonoBehaviour, IDamageable
    {
        [SerializeField] UnityEvent onPlayerDeadEvent = null;

        public void OnDamage(float damage, GameObject performer)
        {
            GameManager.Instance.Cycle.FinishGame();
            onPlayerDeadEvent?.Invoke();
        }
    }
}
