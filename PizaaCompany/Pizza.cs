using System;
using System.Collections.Generic;

namespace PizaaCompany
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; set; }

        protected Pizza()
        {
             Toppings = new List<string>();
        }
        public void Prepare()
        {
            Console.WriteLine("Preparing {0}....", this.Name);
            Console.WriteLine("Tossing {0} ....", string.IsNullOrWhiteSpace(this.Dough)? string.Empty : this.Dough);
            Console.WriteLine("Adding {0}....", string.IsNullOrWhiteSpace(this.Sauce) ? string.Empty : this.Sauce);
            Console.WriteLine("Adding Toppings {0}....", string.Join(", ", Toppings));
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 min at 360 tem....");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting in to diagonal slices ....");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place {0} pizaa in offical pizza store box....", this.Name);
        }
    }
}
