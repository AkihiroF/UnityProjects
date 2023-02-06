namespace Decorator.VariantsHotDogs
{
    public class HotDogCezar : HotdogDecorator
    {
        public HotDogCezar(string name, AHotdog baseClass, Ingridients.Ingridients ) : base(name, baseClass)
        {
        }
    }
}