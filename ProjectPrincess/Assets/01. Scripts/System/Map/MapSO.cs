using UnityEngine;

namespace Maps
{
    [CreateAssetMenu(menuName = "SO/Map/MapData")]
    public class MapSO : ScriptableObject
    {
        public Map MapPrefab = null;
        public float MapSize = 3f;   
    }
}
