using Adapter_5;


public class Program
{
    public static void Main(string[] args)
    {
        
        INewInterface newLogger = new NewRegister();

        
        IOldInterface loggerAdapter = new Adapter(newLogger);

        
        loggerAdapter.SaveMessage("To jest wiadomość informacyjna.");
        loggerAdapter.SaveError("To jest komunikat o błędzie.");

    }
}