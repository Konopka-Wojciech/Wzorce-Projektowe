

namespace Singleton_Zad1
{
    public sealed class NotificationService
    {


        private  List<string> Logs;

        private static  NotificationService? _notificationService;
        private NotificationService()
        {
            Logs = new List<string>();
        }

        public static NotificationService getNotificationService()
        {
            if (_notificationService == null)
            {
                _notificationService = new NotificationService();
            }

            return _notificationService;
        }

        private  Dictionary<int, string> Notes = new Dictionary<int, string>()
        {
            {404,"Not found"},
            {502,"Bad gateway"},
            {504,"Gateway timeout"}
        };
        
        public  void showNotification(int code)
        {
            if (code == 404)
            {
                Console.WriteLine(Notes.GetValueOrDefault(404));
                Logs.Add(DateTime.Now.ToString()+" "+Notes.GetValueOrDefault(404));
            }
            if (code == 504)
            {
                Console.WriteLine(Notes.GetValueOrDefault(504));
                Logs.Add(DateTime.Now.ToString() + " " + Notes.GetValueOrDefault(504));
            }
            if (code == 502)
            {
                Console.WriteLine(Notes.GetValueOrDefault(502));
                Logs.Add(DateTime.Now.ToString() + " " + Notes.GetValueOrDefault(502));
            }



        }
        
        public  void getAllLogs()
        {
            foreach (var item in Logs)
            {
                Console.WriteLine(item);
            }
        }

    }
}
