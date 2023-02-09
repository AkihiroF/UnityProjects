using UnityEngine;

namespace _Source.Command
{
    public struct CommandStruct
    {
        public CommandStruct(ICommand command, Vector2 position)
        {
            Command = command;
            Position = position;
        }

        public ICommand Command;
        public Vector2 Position;
    }
}