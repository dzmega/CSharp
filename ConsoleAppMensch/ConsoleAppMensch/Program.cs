using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMensch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mensch ich = new Mensch();
            ich.Vorname = "David";
            ich.Nachname = "Zygmunt";

            Console.WriteLine(ich.Vorname);
            Console.WriteLine(ich.Heiraten("Zygmunt"));
            Console.WriteLine(ich.Geburtstag());
            Console.ReadKey();
        }
    }
}
