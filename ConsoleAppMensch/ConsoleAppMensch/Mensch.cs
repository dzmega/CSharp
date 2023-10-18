using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMensch
{
    public class Mensch
    {
        private int alter;
        private string familienstand;
        private string nachname;
        private string vorname;

        public Mensch()
        {
            this.familienstand = "ledig";
            this.alter = 0;
        }
        public Mensch(string vorname):this()
        {
            this.vorname = vorname;
        }

        public int Alter
        {
            get { return alter; }
        }
        public string Familienstand
        {
            get { return familienstand; }
        }

        public string Nachname { get => nachname; set => nachname = value; }
        public string Vorname { get => vorname; set => vorname = value; }

        public string Heiraten(string neuerName)
        {
            if(familienstand == "verheiratet")
            {
                return "Sie sind schon verheiratet";
            }
            else
            {
                nachname = neuerName;
                familienstand = "verheiratet";
                return "Herzlichen Glückwunsch";
            }
        }
        public int Geburtstag()
        {
            return ++alter;
        }
    }
}
