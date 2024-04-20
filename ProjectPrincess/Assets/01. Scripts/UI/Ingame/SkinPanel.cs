using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Players;

public class SkinPanel : MonoBehaviour
{
    [SerializeField] Sprite[] skinImages;
    [SerializeField] Image selectSkinImage;

    public void SelectSkin(int index)
    {
        selectSkinImage.sprite = skinImages[index];
        //UpdateSkin
    }
}
