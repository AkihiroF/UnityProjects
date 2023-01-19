using _Source.Input;

namespace _Source.Core
{
    public class Game
    {
        public Game(PlayerInput input, InputHandler inputHandler)
        {
            _input = input;
            _inputHandler = inputHandler;
            EnableInput();
            Bind();
        }

        public void EnableInput() => _input.PlayerAction.Enable();
        public void DisableInput() => _input.PlayerAction.Disable();
        private void Bind()
        {
            _input.PlayerAction.Attack.performed += _inputHandler.Attack;
        }

        private PlayerInput _input;
        private InputHandler _inputHandler;
        
    }
}