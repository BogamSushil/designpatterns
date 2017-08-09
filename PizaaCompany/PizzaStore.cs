using System;

namespace PizaaCompany
{
    public class PizzaStore
    {
        public Pizza OrderPizza(PizzaType type)
        {
            Pizza pizza;
            switch (type)
            {
                case PizzaType.Cheese:
                    pizza = new CheesePizza();
                    break;
                case PizzaType.Veggie:
                    pizza = new VeggiePizza();
                    break;
                case PizzaType.Corn:
                    pizza = new CornPizza();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("type");
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            Console.WriteLine("Pizza Delivered");
            return pizza;


        }
    }
}
