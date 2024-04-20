using Core;
using TMPro;
using UnityEngine;

namespace UI.Ingame
{
    public class ResultPanel : UIPanel
    {
        [SerializeField] TMP_Text bestScoreText;
        [SerializeField] TMP_Text currentScoreText;
        [SerializeField] TMP_Text coinText;

        protected override void Awake()
        {
            base.Awake();
            gameObject.SetActive(false);
        }

        public void Init()
        {
            if(GameManager.Instance.CurrentScore > DataManager.PlayerData.BestScore)
                DataManager.PlayerData.BestScore = GameManager.Instance.CurrentScore;

            bestScoreText.text = $"BEST : {DataManager.PlayerData.BestScore}";
            currentScoreText.text = $"{GameManager.Instance.CurrentScore}";
            coinText.text = $"{GameManager.Instance.EarnedCoin}";

            DataManager.PlayerData.Coin += GameManager.Instance.EarnedCoin;
        }
    }
}
