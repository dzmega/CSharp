using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensoftware
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double betrag;
            double gezahlt;
            double back;
            int backint;
            int zweiEUR = 0;
            int einEUR = 0;
            int fuenfzigCent = 0;
            int zwanzigCent = 0;
            int zehnCent = 0;
            int fuenfCent = 0;
            int zweiCent = 0;
            int einCent = 0;

            Console.Write("Rechnungsbetrag: ");
            betrag = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gezahlter Betrag: ");
            gezahlt = Convert.ToDouble(Console.ReadLine());

            back = gezahlt - betrag;
            Console.WriteLine("===============");
            Console.WriteLine("Rückgeld: " + back + " EUR");
            Console.WriteLine("===============");

            back = back * 100;
            backint = Convert.ToInt32(back);

            zweiEUR = backint / 200;
            backint = backint % 200;

            einEUR = backint / 100;
            backint = backint % 100;

            fuenfzigCent = backint / 50;
            backint = backint % 50;

            zwanzigCent = backint / 20;
            backint = backint % 20;

            zehnCent = backint / 10;
            backint = backint % 10;

            fuenfCent = backint / 5;
            backint = backint % 5;

            zweiCent = backint / 2;
            backint = backint % 2;

            einCent = backint / 1;

            Console.WriteLine("Cent 1: " + einCent);
            Console.WriteLine("Cent 2: " + zweiCent);
            Console.WriteLine("Cent 5: " + fuenfCent);
            Console.WriteLine("Cent 10: " + zehnCent);
            Console.WriteLine("Cent 20: " + zwanzigCent);
            Console.WriteLine("Cent 50: " + fuenfzigCent);
            Console.WriteLine("1 EUR: " + einEUR);
            Console.WriteLine("2 EUR: " + zweiEUR);

            Console.ReadKey();
        }
    }
}