using System;
using System.Collections.Generic;
using UnityEngine;

namespace _Source.Command
{
    public class CommandInvoker : MonoBehaviour
    {
        private const int CountCommand = 2;
        private List<CommandStruct> _commands;

        private void Start()
        {
            _commands = new List<CommandStruct>();
        }

        public void Execute(ICommand command, Vector2 position)
        {
            if (_commands.Count == CountCommand)
                RemoveLastPoint();
            _commands.Add(new CommandStruct(command, position));
        }

        public void DoIt()
        {
            _commands.ForEach((x) => x.Command.Invoke(x.Position));
            _commands = new List<CommandStruct>();
        }

        private void RemoveLastPoint()
        {
            for (int i = 0; i < CountCommand; i++)
            {
                if (i == CountCommand - 1)
                {
                    _commands.Remove(_commands[i]);
                }
                else
                {
                    _commands[i] = _commands[i + 1];
                }
            }
        }
    }
}