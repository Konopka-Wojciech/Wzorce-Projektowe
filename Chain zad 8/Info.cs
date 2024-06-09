using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Info : Logger
    {
        protected override bool CanHandle(LogLevel level)
        {
            return level == LogLevel.INFO;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("INFO: " + message);
        }
    }
}
