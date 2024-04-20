using UnityEngine;

[CreateAssetMenu(menuName = "SO/Map")]
public class MapSO : ScriptableObject
{
    [SerializeField] GameObject[] obstacle;

    public GameObject GetObstacle(int index)
    {
        return obstacle[index];
    }
}
