using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Cheese { get; set; }
        public List<string> Meat { get; set; }

        public Pizza() 
        {
            Meat = new List<string>();
            Cheese = new List<string>();
        }

        public void EatPizza()
        {
            Console.WriteLine($"Dough: {Dough}");
            Console.WriteLine($"Sauce: {Sauce}");
            Console.WriteLine("Meat toppings:");
            foreach ( var item in Meat ) 
            {
                Console.WriteLine(item);  
            }
            Console.WriteLine("Cheese:");
            foreach (var item in Cheese)
            {
                Console.WriteLine(item);
            }
        }




    }
}
