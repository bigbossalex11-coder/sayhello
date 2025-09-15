using System.Xml.Linq;

namespace sayhello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sayhello("World");
            Console.ReadLine();
        }

        static void Sayhello(string name)
        {
            {
                Console.WriteLine($"Hello, {name}");
            }
        }
    }
}