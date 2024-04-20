using System.Collections.Generic;

namespace Core
{
    [System.Serializable]
    public class PlayerData
    {
        public List<int> UnlockedSkinList = null;
        public int BestScore = 0;
        public int Coin = 0;

        public void CreateData()
        {
            UnlockedSkinList = new List<int>();
            BestScore = 0;
        }
    }
}
