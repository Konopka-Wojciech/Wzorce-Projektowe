namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Coffee coffee = new BlackCoffee();
            Console.WriteLine($"Koszt kawy to: {coffee.price()}");

            coffee = new MilkDecorator(coffee);
            Console.WriteLine(($"Koszt kawy z mlekiem: {coffee.price()}"));

            coffee = new SugarDecorator(coffee);
            Console.WriteLine(($"Koszt kawy z mlekiem: {coffee.price()}"));


        }
    }
}
