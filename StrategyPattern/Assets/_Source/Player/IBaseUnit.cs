using _Source.Player.Stategies;

namespace _Source.Player
{
    public interface IBaseUnit
    {
        public void SetStrategy(IAttackStrategy strategy);
        public void PerformAttack();
    }
}