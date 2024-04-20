using UnityEngine;

namespace Core
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        private GameCycle cycle = null;
        public GameCycle Cycle => cycle;

        public PlayerData data = null;

        private void Awake()
        {
            if(Instance != null)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            
            cycle = GetComponent<GameCycle>();
            DataManager.LoadData();
            data = DataManager.PlayerData;
        }

        private void OnDestroy()
        {
            DataManager.SaveData();
        }
    }
}
