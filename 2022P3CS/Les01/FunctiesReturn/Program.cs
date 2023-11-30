using System;

namespace FunctiesReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: ");
            Console.WriteLine("Your name is: " + Name());
            Console.ReadLine();
        }
        static string Name()
        {
            string name = Console.ReadLine();
            return name;
        }
    }
}
