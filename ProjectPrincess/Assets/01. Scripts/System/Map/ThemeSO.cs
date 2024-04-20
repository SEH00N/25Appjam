using UnityEngine;

namespace Maps
{
    [CreateAssetMenu(menuName = "SO/Map/Theme")]
    public class ThemeSO : ScriptableObject
    {
        [SerializeField] MapSO[] maps;
        public MapSO[] Maps => maps;

        public MapSO this[int index] => maps[index];
    }
}
