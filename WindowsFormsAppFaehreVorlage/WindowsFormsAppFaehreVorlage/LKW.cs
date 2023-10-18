using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFaehreVorlage
{
    public class LKW:Fahrzeug
    {
        private double gesamtgewicht;

        public LKW(decimal gesamtPreis, string kennzeichen, double länge, int leergewicht, string marke, double gesamtgewicht):base()
        {
            GesamtPreis = gesamtPreis;
            Kennzeichen = kennzeichen;
            Länge = länge;
            Leergewicht = leergewicht;
            Marke = marke;
            this.gesamtgewicht = gesamtgewicht;
        }
    }
}
