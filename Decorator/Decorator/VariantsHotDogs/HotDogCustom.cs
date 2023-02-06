using System;
using System.Collections.Generic;

namespace Decorator.VariantsHotDogs
{
    public class HotDogCustom : HotdogDecorator
    {
        private List<Ingridients.Ingridients> _additionalIngredients;
        public HotDogCustom(string name, AHotdog baseClass) : base(name, baseClass)
        {
        }
        public HotDogCustom(string name, AHotdog baseClass, List<Ingridients.Ingridients> ingridientsList) : base(name, baseClass)
        {
            _additionalIngredients = ingridientsList;
        }

        public void AddIngridient(Ingridients.Ingridients ingridient)
        {
            try
            {
                _additionalIngredients.Add(ingridient);
            }
            catch (Exception e)
            {
                Console.WriteLine("Why are you gay?");
            }
        }

        private int GetPriceIngridients()
        {
            var price = 0;
            foreach (var ingr in _additionalIngredients)
            {
                price += ingr.Cost;
            }
            return price;
        }

        public override int GetCost()
        {
            return base.GetCost() + GetPriceIngridients();
        }

        public override string GetName()
        {
            string addName = "";
            foreach (var addd in _additionalIngredients)
            {
                addName += $" {addd.Name} ";
            }
            return base.GetName() + $" + ({addName})";
        }
    }
}