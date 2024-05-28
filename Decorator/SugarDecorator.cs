using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class SugarDecorator: CoffeeDecorator
    
    {
        public SugarDecorator(Coffee coffee) : base(coffee) { }

        public override double price()
        {
            return base.price() + 2.00;
        }  

    }
}
