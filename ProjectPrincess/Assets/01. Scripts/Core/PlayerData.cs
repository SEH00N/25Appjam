using System.Collections.Generic;

namespace Core
{
    [System.Serializable]
    public class PlayerData
    {
        public List<int> UnlockedSkinList = null;

        public void CreateData()
        {
            UnlockedSkinList = new List<int>();
        }
    }
}
