using Collisions;
using Core;
using UnityEngine;
using UnityEngine.Events;

namespace Players
{
    public class PlayerHealth : MonoBehaviour, IDamageable
    {
        [SerializeField] GameObject endAudio;
        [SerializeField] UnityEvent onPlayerDeadEvent = null;

        public void OnDamage(float damage, GameObject performer)
        {
            Instantiate(endAudio,transform.position, Quaternion.identity);
            GameManager.Instance.Cycle.FinishGame();
            onPlayerDeadEvent?.Invoke();
        }
    }
}
