using System;
using System.Threading;

namespace TrafficLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("STOP !");
            Thread.Sleep(2000);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("READY !");
            Thread.Sleep(2000);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("GO! ");
            Thread.Sleep(2000);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }
    }
}
