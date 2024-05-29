using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4_adapter
{
    internal class Adapter : IArea
    {
        private Square _square;

        public Adapter(Square square)
        {
            _square = square;
        }

        public double GetArea()
        {
            return _square.Side * _square.Side;
        }

    }
}
