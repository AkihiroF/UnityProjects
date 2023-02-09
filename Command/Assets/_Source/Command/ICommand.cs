using UnityEngine;

namespace _Source.Command
{
    public interface ICommand
    {
        public void Invoke(Vector2 position);
        public void UnDo();
    }
}