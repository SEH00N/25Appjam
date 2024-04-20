using Core;
using UnityEngine;

namespace UI
{
    public class TopPanel : MonoBehaviour
    {
        [SerializeField] NumberTextUI coinUI = null;
        [SerializeField] NumberTextUI scoreUI = null;
        
        private void Start()
        {
            Init();
        }

        public void Init()
        {
            coinUI.SetText(DataManager.PlayerData.Coin);
            scoreUI.SetText(DataManager.PlayerData.BestScore);
        }
    }
}
