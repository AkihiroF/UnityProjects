namespace Decorator
{
    public abstract class AHotdog
    {
        protected string Name;
        protected int Cost;

        public AHotdog(string name)
        {
            Name = name;
            Cost = this.GetHashCode();
        }

        public abstract string GetName();
        public abstract int GetCost();
    }
}