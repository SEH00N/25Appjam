using Players;
using UnityEngine;
using UnityEngine.Events;

namespace Core
{
    public class GameCycle : MonoBehaviour
    {
        [SerializeField] UnityEvent onGameStartedEvent = null;
        [SerializeField] UnityEvent onGameFinishedEvent = null;
        [SerializeField] UnityEvent onGameResetEvent = null;

        public void StartGame()
        {
            onGameStartedEvent?.Invoke();
        }

        public void FinishGame()
        {
            onGameFinishedEvent?.Invoke();
        }

        public void ResetGame()
        {
            onGameResetEvent?.Invoke();
            GameManager.Instance.EarnedCoin = 0;
            GameManager.Instance.CurrentScore = 0;
        }
    }
}
