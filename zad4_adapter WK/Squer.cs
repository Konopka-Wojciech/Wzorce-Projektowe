using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4_adapter
{
    internal class Square
    {
        private double _side;

        public Square(double side)
        {
              this._side = side;
        }

        public double Side
        {
            get { return _side; }
            set { _side = value; }
        }


    }
}
