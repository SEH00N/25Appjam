using UnityEngine;

namespace Skins
{
    [CreateAssetMenu(menuName = "SO/Skin/SkinData")]
    public class SkinSO : ScriptableObject
    {
        public string SkinName = "";
        public GameObject Visual = null;
    }
}
