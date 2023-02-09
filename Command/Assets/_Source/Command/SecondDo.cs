using UnityEngine;

namespace _Source.Command
{
    public class SecondDo : ICommand
    {
        private Transform _player;

        public SecondDo(Transform player)
        {
            _player = player;
        }

        public void Invoke(Vector2 position)
        {
            _player.position = position;
        }

        public void UnDo()
        {
            throw new System.NotImplementedException();
        }
    }
}