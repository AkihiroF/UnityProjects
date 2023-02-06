namespace Decorator.Ingridients
{
    public struct Ingridients
    {
        public Ingridients(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public readonly string Name;
        public readonly int Cost;
    }
}