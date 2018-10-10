using System;

namespace GuessMe.cli
{
    class Program
    {
        private static string name;
        
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.Write("Hello " + name + "!");
            Console.ReadKey();
        }
            
             
    }
}