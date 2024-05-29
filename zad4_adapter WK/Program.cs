
namespace zad4_adapter
{
    internal class Program
    {
            public static void Main(string[] args)
            {
                Console.Write($"Podaj długość boku: ");
                double side = Convert.ToDouble(Console.ReadLine());
                Square square = new Square(side);
                IArea squareAdapter = new Adapter(square);
                PrintArea(squareAdapter);
            }

            static void PrintArea(IArea square)
            {
                Console.WriteLine("Pole wynosi: " + square.GetArea());
            }
        



    }
}
