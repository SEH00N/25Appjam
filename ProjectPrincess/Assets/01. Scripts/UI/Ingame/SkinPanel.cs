using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Players;
using UnityEngine.Events;

namespace UI
{
    public class SkinPanel : UIPanel
    {
        [SerializeField] Sprite[] skinImages;
        [SerializeField] Image selectSkinImage;

        [SerializeField] PlayerSkin skin = null;

        public void SelectSkin(int index)
        {
            selectSkinImage.sprite = skinImages[index];
            skin.UpdateSkin(index);
            //UpdateSkin
        }
    }
}
