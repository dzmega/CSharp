using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppAutorennen
{
    public class Auto : Figur, IConsoleObjects
    {
        public void Display()
        {
            Console.SetCursorPosition(this.X, this.Y);
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = this.Color;
            Console.Write(".-'--`-._ ");
            Console.SetCursorPosition(this.X, this.Y + 1);
            Console.Write("'-O---O--'");
            Console.ForegroundColor = c;


        }

        public void Drive(Object lockObject)
        {
            while (X < 100)
            {
                Thread.Sleep(Speed);
                lock (lockObject)
                {
                    Console.SetCursorPosition(this.X, this.Y);
                    Console.Write("       ");
                    Console.SetCursorPosition(this.X, this.Y + 1);
                    Console.Write("       ");
                    Console.SetCursorPosition(this.X, this.Y + 2);
                    Console.Write("       ");
                    X += 1;
                    Display();
                }
            }
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
