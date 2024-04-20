using Collisions;
using Core;
using UnityEngine;
using UnityEngine.Events;

namespace Players
{
    public class PlayerHealth : MonoBehaviour, IDamaeable
    {
        [SerializeField] UnityEvent onPlayerDeadEvent = null;

        public void OnDamage(float damage, GameObject performer)
        {
            GameManager.Instance.Cycle.FinishGame();
            Destroy(gameObject);
            onPlayerDeadEvent?.Invoke();
        }
    }
}
