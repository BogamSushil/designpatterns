using System.Collections.Generic;

namespace PizaaCompany
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Name = "CheesePizza";
            Toppings = new List<string>() { "Mozzarella", "Extra Mozzarella Cheese", "tomatoes", "onions", "capsicum" };
            Dough = "Whole Grain Dough";
            Sauce = "BBQ Sauce";
        }
    }

}
