using System.Collections.Generic;

namespace PizaaCompany
{
    public class VeggiePizza: Pizza
    {
        public VeggiePizza()
        {
            Name = "VeggiePizza";
            Toppings = new List<string>() { "Mozzarella", "Corns", "tomatoes", "onions", "capsicum", "Jalapeno", "Olives" };
            Dough = "Whole Grain Dough";
            Sauce = "tomato and garlic Sauce";
        }
    }
}
