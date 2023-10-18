using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Person
    {
        private int alter;
        private string nachname;
        private string vorname;

        public Person()
        {

        }

        public Person(string vorname, string nachname, int alter)
        {
            this.alter = alter;
            this.nachname = nachname;
            this.vorname = vorname;
        }

        public int Alter { get => alter; set => alter = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Vorname { get => vorname; set => vorname = value; }

        public int Geburtstag()
        {
            return alter++;
        }

        public override string ToString()
        {
            return vorname + " " + nachname + " " + alter;
        }
    }
}
