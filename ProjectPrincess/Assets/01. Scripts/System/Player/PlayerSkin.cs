using player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkin : MonoBehaviour
{
    [SerializeField] SkinSO[] skins;

    public Mesh SkinUpdate(int index)
    {
        return skins[index].mesh;
    }
}
