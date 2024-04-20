using System.Collections.Generic;
using System.Linq;
using Core;
using Extensions;
using Skins;
using UnityEngine;

namespace UI.Shop
{
    public class GachaPanel : UIPanel
    {
        [SerializeField] SkinListSO skinList = null;

        private GachaResultPanel resultPanel = null;

        private List<int> gachaList = null;
        private PlayerData playerData = null;

        protected override void Awake()
        {
            base.Awake();

            resultPanel = transform.parent.Find("GachaResultPanel").GetComponent<GachaResultPanel>();
        }

        private void Start()
        {
            playerData = DataManager.PlayerData;
            CreateGachaList();
        }

        public void GachaSkin()
        {
            int unlockedSkin = gachaList.PickRandom();
            playerData.UnlockedSkinList.Add(unlockedSkin);
            gachaList.Remove(unlockedSkin);

            resultPanel.DisplayResult(unlockedSkin);
        }

        private void CreateGachaList()
        {
            gachaList = new List<int>();
            for(int i = 0; i < skinList.Skins.Length; ++i)
                gachaList.Add(i);

            playerData.UnlockedSkinList.ForEach(i => {
                gachaList.Remove(i);
            });
        }
    }
}
