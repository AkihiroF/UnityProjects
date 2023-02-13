using System.Collections.Generic;
using _Source.Core;
using UnityEngine;

namespace _Source.Command
{
    public class FirstDo : ICommand
    {
        private GameObject _prefab;
        private List<GameObject> _objects;

        public FirstDo(GameObject prefab)
        {
            _prefab = prefab;
        }
        public void Invoke(Vector2 position)
        {
            SpawnerObj.SpawnObj(_prefab, position);
        }

        public void UnDo()
        {
            
        }
    }
}