using System.Collections.Generic;
using Extensions;
using UnityEngine;

namespace Maps
{
    public class MapLoader : MonoBehaviour
    {
        [SerializeField] ThemeSO dafuletTheme = null;
        [SerializeField] List<ThemeSO> themes = null;

        [Space(15f)]
        [SerializeField] Transform mapSpawnPosition = null;
        [SerializeField] int themeRerollThreshold = 10;
        [SerializeField] float speedFactor = 1f;

        private Vector3 nextSpawnPosition = Vector3.zero;
        private ThemeSO currentTheme = null;
        private List<Map> mapInstnaces = null;

        private int rerollCounter = 0;

        private void Awake()
        {
            mapInstnaces = new List<Map>();
        }

        private void Start()
        {
            ResetMap();
        }

        public void StartCycle()
        {
            Cycle();
        }

        public void StopCycle()
        {
            StopAllCoroutines();
        }

        private void Cycle()
        {
            rerollCounter++;
            if(rerollCounter >= themeRerollThreshold)
            {
                rerollCounter = 0;
                RerollTheme();
            }

            MapSO spawnedMapData = SpawnMap();
            StartCoroutine(this.DelayCoroutine(spawnedMapData.MapSize / speedFactor, Cycle));
        }

        private MapSO SpawnMap()
        {
            MapSO mapData = currentTheme.Maps.PickRandom();
            Map instance = Instantiate(mapData.MapPrefab, nextSpawnPosition, Quaternion.identity);
            nextSpawnPosition += Vector3.right * mapData.MapSize;
            mapInstnaces.Add(instance);

            return mapData;
        }

        private void RerollTheme()
        {
            currentTheme = themes.PickRandom();
        }

        public void ResetMap()
        {
            mapInstnaces.ForEach(i => {
                Destroy(i.gameObject);
            });
            mapInstnaces.Clear();

            rerollCounter = 0;
            currentTheme = dafuletTheme;
            nextSpawnPosition = mapSpawnPosition.position;
        }
    }
}
