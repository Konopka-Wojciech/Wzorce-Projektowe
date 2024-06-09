using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Warning : Logger
    {
        protected override bool CanHandle(LogLevel level)
        {
            return level == LogLevel.WARNING;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("WARNING: " + message);
        }
    }
}
