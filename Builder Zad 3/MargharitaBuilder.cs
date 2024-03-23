using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class MargharitaBuilder : IPizzaBuilder
    {
        private Pizza margharita;

        public MargharitaBuilder()
        {
            margharita = new Pizza();
        }

        public void BuildDough()
        {
            margharita.Dough = "Thin";
        }

        public void BuildSauce() 
        {
            margharita.Sauce = "red";

        }
        public void BuildCheese()
        {
            margharita.Cheese.Add("mozarella");
        }
        public void BuildMeat()
        {
        }

        public Pizza GetPizza() 
        { 
            return margharita; 
        }


    }
}
