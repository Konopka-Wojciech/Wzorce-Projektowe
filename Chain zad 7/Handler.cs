using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace tickets
{
    internal class Handler
    {
        protected Handler? _nextHandler;

        public void SetNext(Handler handler)
        {
            _nextHandler = handler;
        }

        public virtual string Handle(Ticket request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            return null;
        }


    }
}
