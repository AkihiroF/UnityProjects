using UnityEngine;

namespace _Source.Core
{
    public class SpawnerObj : MonoBehaviour
    {
        public static void SpawnObj(GameObject prefab, Vector2 position)
        {
            Instantiate(prefab, position, Quaternion.identity);
        }
    }
}