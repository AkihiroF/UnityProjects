using System;
using _Source.Input;
using _Source.Player;
using _Source.Player.Stategies;
using UnityEngine;

namespace _Source.Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private Animator animator;
        private void Awake()
        {
            var input = new PlayerInput();
            var attackStrategy = new AttackStrategy(Animator.StringToHash("isIdle"), animator);
            var player = new AttackPerformer(attackStrategy);
            var inputHandler = new InputHandler(player);
            var game = new Game(input, inputHandler);
        }
    }
}
