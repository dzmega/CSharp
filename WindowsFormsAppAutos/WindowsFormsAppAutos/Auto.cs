using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppAutos
{
    public class Auto
    {
        private double aktuelleFuellung;
        private int kilometerstand;
        private double maxFuellmenge;
        private double verbrauch;
        private string kennzeichen;

        public double AktuelleFuellung { get => aktuelleFuellung; }
        public int Kilometerstand { get => kilometerstand; }
        public double MaxFuellmenge { get => maxFuellmenge; }
        public double Verbrauch { get => verbrauch; }
        public string Kennzeichen { get => kennzeichen; set => kennzeichen = value; }

        public Auto(string kennzeichen, double aktuelleFuellung, int kilometerstand, double verbrauch)
        {
            this.kennzeichen = kennzeichen;
            this.aktuelleFuellung = aktuelleFuellung;
            this.kilometerstand = kilometerstand;
            this.verbrauch = verbrauch;
        }
        public Auto(string kennzeichen, double aktuelleFuellung, int kilometerstand, double maxFuellmenge, double verbrauch)
        {
            this.kennzeichen = kennzeichen;
            this.aktuelleFuellung = aktuelleFuellung;
            this.kilometerstand = kilometerstand;
            this.maxFuellmenge = maxFuellmenge;
            this.verbrauch = verbrauch;
        }

        public int Fahren(int anzahlKm)
        {
            if (anzahlKm * verbrauch / 100 <= aktuelleFuellung)
            {
                aktuelleFuellung -= anzahlKm * verbrauch / 100;
                kilometerstand += anzahlKm;
                Console.WriteLine(aktuelleFuellung);
            }
            else
            {
                Console.WriteLine(aktuelleFuellung);
                aktuelleFuellung = 0;
            }
            return anzahlKm;
        }

        public double Tanken(double menge)
        {
            if (menge + aktuelleFuellung <= maxFuellmenge)
            {
                aktuelleFuellung = aktuelleFuellung + menge;
                Console.WriteLine("Tankvorgang erfolgreich");
            }
            else
            {
                Console.WriteLine("Weniger Tanken");
            }
            return aktuelleFuellung;
        }

        public override string ToString()
        {
            return kennzeichen;
        }
    }
}