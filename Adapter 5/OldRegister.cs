using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_5
{
    internal class OldRegister :IOldInterface
    {
        public void SaveMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        public void SaveError(string error)
        {
            Console.WriteLine("Error: " + error);
        }

    }
}
