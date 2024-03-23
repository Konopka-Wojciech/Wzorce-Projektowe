using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Director
    {
        private IPizzaBuilder _builder;

        public Director(IPizzaBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructPizza()
        {
            _builder.BuildSauce();
            _builder.BuildDough();
            _builder.BuildMeat();
            _builder.BuildCheese();
            
        }



    }

}
