using System;
using _Source.Input;
using UnityEngine;

namespace _Source.Core
{
    public class Bootstrapper : MonoBehaviour
    {
        private void Awake()
        {
            var input = new PlayerInput();
            var inputHandler = new InputHandler();
            var game = new Game(input, inputHandler);
        }
    }
}
