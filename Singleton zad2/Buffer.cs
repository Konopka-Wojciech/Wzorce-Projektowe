

namespace Singleton_zad2
{
    public sealed class Buffer
    {
        private static Buffer? _instance;
        private List<string> printBuffer;
        private Buffer()
        {
           printBuffer = new List<string>();
        }

        public static Buffer getPrintBuffer()
        {
            if (_instance == null)
            {
                _instance = new Buffer();
            }
            return _instance;

        }

        public void addFile(string file)
        {
            printBuffer.Add(file);
        }


        public void Print() 
        {
            if (printBuffer.Count > 0)
            {
                Console.WriteLine("Printing:");
                foreach (var file in printBuffer)
                {
                    Console.WriteLine(file);

                }
                printBuffer.Clear();
            }
            else 
            {   
                Console.WriteLine("Buffer is empty");
            }
        }
        public void clear() 
        {
            printBuffer.Clear();
        }

    }

}

