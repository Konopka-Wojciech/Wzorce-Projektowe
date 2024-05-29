using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_5
{
    internal class Adapter :IOldInterface
    {
        private readonly INewInterface _newLogger;

        public Adapter(INewInterface newLogger)
        {
            _newLogger = newLogger;
        }

        public void SaveMessage(string message)
        {
            _newLogger.LogNewMessage(message);
        }

        public void SaveError(string message)
        {
            _newLogger.LogNewError(message);
        }




    }
}
