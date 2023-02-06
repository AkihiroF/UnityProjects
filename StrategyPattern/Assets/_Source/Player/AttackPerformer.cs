using _Source.Player.Stategies;
using UnityEngine;

namespace _Source.Player
{
    public class AttackPerformer : IBaseUnit
    {
        private IAttackStrategy _currentStrategy;

        public  AttackPerformer(IAttackStrategy startStrategy)
        {
            _currentStrategy = startStrategy;
        }
        public void SetStrategy(IAttackStrategy strategy)
        {
            _currentStrategy = strategy;
        }

        public void PerformAttack()
        {
            if(_currentStrategy == null)
                return;
            _currentStrategy.Activate();
        }
    }
}
