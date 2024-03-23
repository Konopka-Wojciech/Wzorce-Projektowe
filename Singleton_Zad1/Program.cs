
namespace Singleton_Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            NotificationService Service = NotificationService.getNotificationService();
            

            List<int> codes = new List<int>();
            Random rnd = new Random();
            codes.Add(404);
            codes.Add(502);
            codes.Add(504);

            Console.WriteLine("Serwis do obsługi komunikatów");
            for (int i = 0; i < 5; i++) 
            {
                Service.showNotification(codes[rnd.Next(0, 3)]);
            }

            Service.getAllLogs();
            
            Console.ReadKey();
        }
    }
}
