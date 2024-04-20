using UnityEngine;

namespace Skins
{
    [CreateAssetMenu(menuName = "SO/Skin/SkinList")]
    public class SkinListSO : ScriptableObject
    {
        [SerializeField] SkinSO[] skins = null;
        public SkinSO[] Skins => skins;

        public SkinSO this[int index] => skins[index];
    }
}
