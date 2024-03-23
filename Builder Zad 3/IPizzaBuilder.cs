using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal interface IPizzaBuilder
    {
        void BuildDough();
        void BuildSauce();
        void BuildMeat();
        void BuildCheese();
        Pizza GetPizza();
    }
    
}
