using System.Collections.Generic;
using _Source.Command;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _Source.Input
{
    public class InputHandler
    {
        public InputHandler(CommandInvoker invoker, Camera camera, List<ICommand> commands)
        {
            _invoker = invoker;
            _camera = camera;
            _commands = commands;
        }

        private List<ICommand> _commands;
        private CommandInvoker _invoker;
        private Camera _camera;


        public void LkmDo(InputAction.CallbackContext obj)
        {
            var pos = _camera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            _invoker.Execute(_commands[0], pos);
        }

        public void PkmDo(InputAction.CallbackContext obj)
        {
            var pos = _camera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            _invoker.Execute(_commands[1], pos);
        }

        public void ReturnDo(InputAction.CallbackContext obj)
        {
            _invoker.DoIt();
        }
    }
}
