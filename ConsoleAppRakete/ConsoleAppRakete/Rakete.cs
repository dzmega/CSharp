using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleAppRakete
{
    public class Rakete : Figur, IConsoleObjects
    {
        public void Display()
        {

            Console.SetCursorPosition(this.X, this.Y);
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = this.Color;
            Console.Write("/-----\\");
            Console.SetCursorPosition(this.X + 1, this.Y - 1);
            Console.Write("/   \\");
            Console.SetCursorPosition(this.X + 2, this.Y - 2);
            Console.Write("/ \\");
            Console.SetCursorPosition(this.X + 3, this.Y - 3);
            Console.Write("|");
            Console.SetCursorPosition(this.X + 3, this.Y - 4);
            Console.Write("^");
            Console.ForegroundColor = c;
        }

        public void MoveUp(object lockobject)
        {
            while(Y > 5)
            {
                Thread.Sleep(100 - Speed);
                lock (lockobject)
                {
                    Console.SetCursorPosition(this.X, this.Y);
                    Console.Write("       ");
                    Y -= 1;
                    Display();
                }
                
            }
        }

        public void Stop()
        {

        }
    }
}
