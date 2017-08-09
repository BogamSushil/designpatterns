using System;
using PizaaCompany;

namespace PizzaShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizza = new PizzaStore();
            pizza.OrderPizza(PizzaType.Corn);
            Console.ReadLine();
        }
    }
}
