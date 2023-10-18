using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOO
{
    public class Mensch
    {
        private string vorname;
        private string nachname;
        private string familienstand;
        private int alter;

        public Mensch()
        {
            this.familienstand = "ledig";
            this.vorname = vorname;
            this.nachname = nachname;
            this.alter = alter;
        }
        public int Alter { 
            get { return alter; } 
            set { alter = value; } 
        }

        public string Vorname { get => vorname; set => vorname = value; }
        public string Familienstand { get => familienstand; private set => familienstand = value; }

        public int Geburtstag()
        {
            alter++;
            return alter;
        }

    }
}
