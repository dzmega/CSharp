using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFaehreVorlage
{
    class Fahrzeug
    {
        private decimal gesamtPreis;
        private string kennzeichen;
        private double laenge;
        private int leergewicht;
        private string marke;

        public Fahrzeug(string kennzeichen, double laenge, int leergewicht )
        {
            Kennzeichen = kennzeichen;
            Laenge = laenge;
            Leergewicht = leergewicht;
        }

        public decimal GesamtPreis
        {
            get
            {
                return gesamtPreis;
            }

            set
            {
                gesamtPreis = value;
            }
        }

        public string Kennzeichen
        {
            get
            {
                return kennzeichen;
            }

            set
            {
                kennzeichen = value;
            }
        }

        public double Laenge
        {
            get
            {
                return laenge;
            }

            set
            {
                laenge = value;
            }
        }

        public int Leergewicht
        {
            get
            {
                return leergewicht;
            }

            set
            {
                leergewicht = value;
            }
        }

        public string Marke
        {
            get
            {
                return marke;
            }

            set
            {
                marke = value;
            }
        }
    }
}
