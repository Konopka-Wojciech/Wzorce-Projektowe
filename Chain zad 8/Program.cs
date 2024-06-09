
namespace Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var infoLogger = new Info();
            var warningLogger = new Warning();
            var errorLogger = new Error();

           
            infoLogger.SetNext(warningLogger);
            warningLogger.SetNext(errorLogger);

           
            var messages = new List<(LogLevel level, string message)>
            {
            (LogLevel.INFO, "This is an informational message."),
            (LogLevel.WARNING, "This is a warning message."),
            (LogLevel.ERROR, "This is an error message."),
            (LogLevel.INFO, "Another informational message."),
            };

            
            foreach (var (level, message) in messages)
            {
                infoLogger.LogMessage(level, message);
            }
        }
    }
}
