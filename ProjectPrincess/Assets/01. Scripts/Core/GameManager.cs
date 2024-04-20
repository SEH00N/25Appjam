using UnityEngine;

namespace Core
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        private GameCycle cycle = null;
        public GameCycle Cycle => cycle;

        private void Awake()
        {
            if(Instance != null)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            
            cycle = GetComponent<GameCycle>();
        }
    }
}
