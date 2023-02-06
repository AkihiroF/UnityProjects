using _Source.Player;
using UnityEngine.InputSystem;

namespace _Source.Input
{
    public class InputHandler
    {
        private AttackPerformer _attackPerformer;

        public InputHandler(AttackPerformer attackPerformer)
        {
            _attackPerformer = attackPerformer;
        }

        public void Attack(InputAction.CallbackContext obj)
        {
            _attackPerformer.PerformAttack();
        }
    }
}
