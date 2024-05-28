using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class CoffeeDecorator:Coffee
    {
        protected Coffee _coffee;

        public CoffeeDecorator(Coffee coffee)
        {
            _coffee = coffee;
        }

        public override double price()
        {
            return _coffee.price();
        }


    }
}
