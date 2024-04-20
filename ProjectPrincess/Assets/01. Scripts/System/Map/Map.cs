using UnityEngine;
using UnityEngine.Events;

namespace Maps
{
    public class Map : MonoBehaviour
    {
        [SerializeField] MapSO mapData = null;
        [SerializeField] UnityEvent<Map> onInitEvent = null;

        public void Init()
        {
            onInitEvent?.Invoke(this);
        }
    }
}
