using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensch mensch = new Mensch("Max","Mustermann",20);

            Console.WriteLine(mensch.Alter + mensch.Familienstand);
            Console.WriteLine("Herzlichen Glückwunsch zum {0}. Geburtstag",mensch.Geburtstag());
            Console.ReadKey();
        }
    }
}
