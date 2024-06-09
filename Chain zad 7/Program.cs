namespace tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var technicalSupport = new Technical();
            var billingSupport = new Billing();
            var generalSupport = new General();

           
            technicalSupport.SetNext(billingSupport);
            billingSupport.SetNext(generalSupport);

           
            var tickets = new List<Ticket>
            {
            new Ticket("technical", "Can't connect to the VPN"),
            new Ticket("billing", "Incorrect charge on invoice"),
            new Ticket("general", "What are your business hours?"),
            new Ticket("technical", "Error 404 on the website")
            };

            
            foreach (var ticket in tickets)
            {
                var result = technicalSupport.Handle(ticket);
                Console.WriteLine(result);
            }
        }
    }
}

