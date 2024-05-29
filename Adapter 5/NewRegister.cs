using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Adapter_5
{
    internal class NewRegister : INewInterface
    {
        public void LogNewMessage(string info)
        {
            Console.WriteLine("INFO: " + info);
        }
        public void LogNewError(string error)
        {
            Console.WriteLine("VIOLATION: " + error);
        }

    }
}
