using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFaehreVorlage
{
    public class Fahrzeug
    {
        private decimal gesamtPreis;
        private string kennzeichen;
        private double länge;
        private int leergewicht;
        private string marke;

        public Fahrzeug()
        {

        }
        public Fahrzeug(decimal gesamtPreis, string kennzeichen, double länge, int leergewicht, string marke)
        {
            this.gesamtPreis = gesamtPreis;
            this.kennzeichen = kennzeichen;
            this.länge = länge;
            this.leergewicht = leergewicht;
            this.marke = marke;
        }

        public decimal GesamtPreis { get => gesamtPreis; set => gesamtPreis = value; }
        public string Kennzeichen { get => kennzeichen; set => kennzeichen = value; }
        public double Länge { get => länge; set => länge = value; }
        public int Leergewicht { get => leergewicht; set => leergewicht = value; }
        public string Marke { get => marke; set => marke = value; }
    }
}
