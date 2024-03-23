namespace Singleton_zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Send items to printer");

            Buffer buffer = Buffer.getPrintBuffer();

            buffer.addFile("file 1");
            buffer.addFile("file 2");
            buffer.Print();
            buffer.Print();

        }
    }
}
