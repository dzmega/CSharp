using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppVorbereitungDataFPA
{
    public class Kunde
    {
        private int kundennummer;
        private string kundenname;
        private string strasse;
        private string plz;
        private string ort;
        private string telefon;

        public Kunde()
        {

        }

        public Kunde(int kundennummer, string kundenname, string strasse, string plz, string ort, string telefon)
        {
            this.kundennummer = kundennummer;
            this.kundenname = kundenname;
            this.strasse = strasse;
            this.plz = plz;
            this.ort = ort;
            this.telefon = telefon;
        }

        public int Kundennummer { get => kundennummer; set => kundennummer = value; }
        public string Kundenname { get => kundenname; set => kundenname = value; }
        public string Strasse { get => strasse; set => strasse = value; }
        public string Plz { get => plz; set => plz = value; }
        public string Ort { get => ort; set => ort = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        public override string ToString()
        {
            return kundennummer + " " + kundenname;
        }
    }
}
