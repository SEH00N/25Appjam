using UnityEngine;
using UnityEngine.Events;

namespace Core
{
    public class GameCycle : MonoBehaviour
    {
        [SerializeField] UnityEvent onGameStartedEvent = null;
        [SerializeField] UnityEvent onGameFinishedEvent = null;

        public void StartGame()
        {
            onGameStartedEvent?.Invoke();
        }

        public void FinishGame()
        {
            onGameFinishedEvent?.Invoke();
        }
    }
}
