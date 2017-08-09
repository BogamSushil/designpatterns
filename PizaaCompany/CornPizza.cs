using System.Collections.Generic;

namespace PizaaCompany
{
    public class CornPizza : Pizza
    {
        public CornPizza()
        {
            Name = "CornPizza";
            Toppings = new List<string>() { "Mozzarella", "Corns", "tomatoes", "onions", "capsicum" };
            Dough = "Whole Grain Dough";
            Sauce = "tomato Sauce";
        }
    }
}
