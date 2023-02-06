using UnityEngine;

namespace _Source.Player.Stategies
{
    public class AttackStrategy : IAttackStrategy
    {
        private int _idAnimation;
        private Animator _animator;

        public AttackStrategy(int idAnimation, Animator animator)
        {
            _idAnimation = idAnimation;
            _animator = animator;
        }
        public void Activate()
        {
            _animator.SetBool(_idAnimation, true);
        }
    }
}