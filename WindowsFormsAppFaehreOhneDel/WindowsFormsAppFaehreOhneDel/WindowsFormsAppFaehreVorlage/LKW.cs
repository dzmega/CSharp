using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFaehreVorlage
{
    class LKW:Fahrzeug
    {
        private decimal gesamtgewicht;
        public LKW(string kennzeichen, double laenge, int leergewicht) :base(kennzeichen, laenge, leergewicht)
        { }

        public decimal Gesamtgewicht
        {
            get
            {
                return gesamtgewicht;
            }

            set
            {
                gesamtgewicht = value;
            }
        }
        public override string ToString()
        {
            return "LKW: " + Kennzeichen;
        }
    }
}
