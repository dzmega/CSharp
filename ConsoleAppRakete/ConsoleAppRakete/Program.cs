using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRakete
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleObjects consoleObjects = new ConsoleObjects();
            Rakete rakete = new Rakete();
            rakete.X = 10;
            rakete.Y = 30;
            rakete.Color = ConsoleColor.Green;
            Rakete rakete1 = new Rakete();
            rakete1.X = 19;
            rakete1.Y = 30;
            rakete1.Color = ConsoleColor.DarkMagenta;
            KomischesDing ding = new KomischesDing();
            ding.X = 30;
            ding.Y = 30;
            ding.Speed = 50;
            ding.Color = ConsoleColor.DarkCyan;
            consoleObjects.AddObject(rakete);
            consoleObjects.AddObject(rakete1);
            consoleObjects.AddObject(ding);
            consoleObjects.DisplayAll();
            consoleObjects.MoveAllUp();
            Console.ReadKey();
        }
    }
}
