using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFaehreVorlage
{
    class PKW:Fahrzeug
    {
        public PKW(string kennzeichen, double laenge, int leergewicht) :base(kennzeichen, laenge, leergewicht)
        { }

        private int personenanzahl;

        public int Personenanzahl
        {
            get
            {
                return personenanzahl;
            }

            set
            {
                personenanzahl = value;
            }
        }
        public override string ToString()
        {
            return "PKW: " +Kennzeichen;
        }
    }
}
