using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAutorennen
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            ConsoleObjects consoleObjects = new ConsoleObjects();
            Auto auto = new Auto();
            auto.X = 10;
            auto.Y = 5;
            auto.Speed = random.Next(10, 100);
            auto.Color = ConsoleColor.Green;

            Auto auto2 = new Auto();
            auto2.X = 10;
            auto2.Y = 10;
            auto2.Speed = random.Next(10, 100);
            auto2.Color = ConsoleColor.Red;
            consoleObjects.AddObject(auto);
            consoleObjects.AddObject(auto2);
            consoleObjects.DisplayAll();
            while (Console.ReadKey().Key != ConsoleKey.End) ;
            consoleObjects.DriveAll();

            Console.ReadKey();
        }
    }
}
