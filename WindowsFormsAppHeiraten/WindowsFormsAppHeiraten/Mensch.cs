using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppHeiraten
{
    public class Mensch
    {
        private string vorname;
        private string nachname;
        private int alter;
        private string familienstand;
        //Auslösende Klasse
        //Signatur festlegen
        public delegate void SchonVerheiratet();
        //Delegate Variable
        public SchonVerheiratet OnSchonVerheiratet = null;

        public Mensch()
        {

        }

        public Mensch(string vorname, string nachname, int alter, string familienstand)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.alter = alter;
            this.familienstand = familienstand;
        }

        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public int Alter { get => alter; set => alter = value; }
        public string Familienstand { get => familienstand; set => familienstand = value; }

        public override string ToString()
        {
            return vorname + " " + nachname;
        }

        public void Heiraten(string newName)
        {
            if(familienstand != "verheiratet")
            {
                if(newName != null)
                {
                    nachname = newName;
                    familienstand = "verheiratet";
                }
            }
            else
            {
                if(OnSchonVerheiratet != null)
                {
                    OnSchonVerheiratet();
                }
            }
        }
    }
}
