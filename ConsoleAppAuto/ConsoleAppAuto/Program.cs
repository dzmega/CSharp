using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAuto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto(0,156345,80,8.5);

            Console.WriteLine("KM-Stand vor der Fahrt: " + auto.Kilometerstand);
            auto.Tanken(50);
            Console.WriteLine("Aktuelle Tankfüllung: " + auto.AktuelleFuellung);
            do
            {
                int km = auto.Fahren(300);
                if (km == 300)
                {
                    Console.WriteLine("Aktueller KM-Stand {0} nach 300 km ", auto.Kilometerstand);
                }
                else
                {
                    Console.WriteLine("Es können nur {0} km zurückgelegt werden", km);
                }
            } while (auto.AktuelleFuellung != 0);
            Console.ReadKey();
        }
    }
}
