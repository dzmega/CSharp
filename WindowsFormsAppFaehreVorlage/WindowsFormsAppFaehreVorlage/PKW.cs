using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFaehreVorlage
{
    public class PKW:Fahrzeug
    {
        private int personenanzahl;

        public PKW(decimal gesamtPreis, string kennzeichen, double länge, int leergewicht, string marke, int personenanzahl):base()
        {
            GesamtPreis = gesamtPreis;
            Kennzeichen = kennzeichen;
            Länge = länge;
            Leergewicht = leergewicht;
            Marke = marke;
            this.personenanzahl = personenanzahl;
        }
    }
}
