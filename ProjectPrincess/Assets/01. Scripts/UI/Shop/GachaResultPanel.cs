using Skins;
using UnityEngine;

namespace UI.Shop
{
    public class GachaResultPanel : UIPanel
    {
        [SerializeField] SkinListSO skinList = null;

        public void DisplayResult(int unlockedSkinIndex)
        {
            gameObject.SetActive(true);
            Display(true);

            SkinSO skinData = skinList[unlockedSkinIndex];
        }
    }
}
