using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAuto
{
    public class Auto
    {
        private double aktuelleFuellung;
        private int kilometerstand;
        private double maxFuellmenge;
        private double verbrauch;

        public Auto(double AktuelleFuellung, int Kilometerstand, double MaxFuellmenge, double Verbrauch)
        {
            aktuelleFuellung = AktuelleFuellung;
            kilometerstand = Kilometerstand;
            maxFuellmenge = MaxFuellmenge;
            verbrauch = Verbrauch;
        }

        public double AktuelleFuellung { get => aktuelleFuellung; set => aktuelleFuellung = value; }
        public int Kilometerstand { get => kilometerstand; set => kilometerstand = value; }
        public double MaxFuellmenge { get => maxFuellmenge; set => maxFuellmenge = value; }
        public double Verbrauch { get => verbrauch; set => verbrauch = value; }

        public double Tanken(double menge)
        {
            if (aktuelleFuellung == maxFuellmenge)
            {
                Console.WriteLine("Der Tank ist bereits voll");
            }
            else
            {
                double temp = aktuelleFuellung + menge;
                if (temp > maxFuellmenge)
                {
                    aktuelleFuellung = maxFuellmenge;
                }
                else
                {
                    aktuelleFuellung += menge;
                }
            }
            return aktuelleFuellung;
        }
        public int Fahren(int anzahlKm)
        {
            if ((100 / verbrauch) * aktuelleFuellung < anzahlKm)
            {
                anzahlKm = Convert.ToInt32((100 / verbrauch) * aktuelleFuellung);
                Console.WriteLine(anzahlKm);
                kilometerstand += anzahlKm;
                aktuelleFuellung = 0;
            }
            else
            {
                aktuelleFuellung -= Convert.ToDouble(anzahlKm / 100) * verbrauch;
                kilometerstand += anzahlKm;
                Console.WriteLine(aktuelleFuellung);
            }
            return anzahlKm;
        }
    }
}
