using System.Collections.Generic;
using Extensions;
using UnityEngine;

namespace Maps
{
    public class MapLoader : MonoBehaviour
    {
        [SerializeField] ThemeSO currentTheme = null;
        [SerializeField] List<ThemeSO> themes = null;

        [Space(15f)]
        [SerializeField] Transform mapSpawnPosition = null;
        [SerializeField] int themeRerollThreshold = 10;
        [SerializeField] float speedFactor = 1f;

        private int rerollCounter = 0;

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
            Instantiate(mapData.MapPrefab, mapSpawnPosition.position, Quaternion.identity);
            mapSpawnPosition.position += Vector3.right * mapData.MapSize;

            return mapData;
        }

        private void RerollTheme()
        {
            currentTheme = themes.PickRandom();
        }
    }
}
