using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public abstract class Logger
    {
        protected Logger? _nextLogger;

        public void SetNext(Logger logger)
        {
            _nextLogger = logger;
        }

        public void LogMessage(LogLevel level, string message)
        {
            if (CanHandle(level))
            {
                Write(message);
            }
            else if (_nextLogger != null)
            {
                _nextLogger.LogMessage(level, message);
            }
        }

        protected abstract bool CanHandle(LogLevel level);
        protected abstract void Write(string message);
    }
}
