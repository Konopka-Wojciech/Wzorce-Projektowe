using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class MilkDecorator : CoffeeDecorator
    {

        public MilkDecorator(Coffee coffee) : base(coffee) { }

        public override double price()
        {
            return base.price() + 3.00;
        }

    }
}
