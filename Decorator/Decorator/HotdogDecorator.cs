namespace Decorator
{
    public class HotdogDecorator : AHotdog
    {
        private AHotdog _main;
        public HotdogDecorator(string name, AHotdog baseClass) : base(name)
        {
            _main = baseClass;
        }

        public override string GetName()
        {
            return Name;
        }

        public override int GetCost()
        {
            return Cost;
        }
    }
}